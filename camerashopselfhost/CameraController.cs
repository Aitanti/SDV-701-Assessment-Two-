using System;
using System.Collections.Generic;
using System.Data;

namespace camerashopselfhost
{
    public class CameraController : System.Web.Http.ApiController
    {

        // Gets camera names for displaying in the frmMain 
        public List<string> GetCameraNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT BrandName FROM camera_brand", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        //Select statement which access the clsCameraEquipment which is the second table in my database 
        public clsBrand GetCamera(string BrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", BrandName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM camera_brand WHERE BrandName = @BrandName", par);
            if (lcResult.Rows.Count > 0)
            {


                return new clsBrand()
                {
                    BrandName = (string)lcResult.Rows[0]["BrandName"], // returns the brand name and slogan and displays it
                    Slogan = (string)lcResult.Rows[0]["Slogan"],
                    CameraList = getCameraEquipment(BrandName)
                };
            }
            else
                return null;
        }

        private List<clsCameraequipment> getCameraEquipment(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Brand_Name", Name);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM camera_equipment WHERE Brand_Name = @Brand_Name", par);
            List<clsCameraequipment> lcWorks = new List<clsCameraequipment>();
            foreach (DataRow dr in lcResult.Rows)
                lcWorks.Add(dataRow2AllWork(dr));
            return lcWorks;
        }
        private Dictionary<string, object> prepareCameraEquipmentParameters(string prBrandName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("BrandName", prBrandName);
            return par;
        }

        public string PostCameraEquipment(clsCameraequipment prCameraEquipment)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO camera_equipment " +
                "(Brand_Name, EquipmentID, Model, Price, Quantity, DateLastModified, Weight, MaxAperture, MegaPixels, MaxApt, FocalLength, BodyType, EquipmentType) " +
                "VALUES (@Brand_Name, @EquipmentID, @Model, @Price, @Quantity, @DateLastModified, @Weight, @MaxAperture, @MegaPixels, MaxApt, FocalLength, BodyType, Equipment)",
                prepareCameraEquipmentParameters(prCameraEquipment));
                if (lcRecCount == 1)
                    return "One Camera Equipment inserted";
                else
                    return "Unexpected Camera Equipment insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareCameraEquipmentParameters(clsCameraequipment prCameraEquipment)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("Brand_Name", prCameraEquipment.Brand_Name);
            par.Add("Model", prCameraEquipment.Model);
            par.Add("Price", prCameraEquipment.Price);
            par.Add("Quantity", prCameraEquipment.Quantity);
            par.Add("DateLastModified", prCameraEquipment.DateLastModified.ToString("yyyy-MM-dd H:mm:ss"));
            par.Add("Weight", prCameraEquipment.Weight);
            par.Add("MaxAperture", prCameraEquipment.MaxAperture);
            par.Add("MegaPixels", prCameraEquipment.Megapixels);
            par.Add("FocalLength", prCameraEquipment.FocalLength);
            par.Add("EquipmentType", prCameraEquipment.EquipmentType);

            return par;
        }

        // Was part of my ordering system

        //private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        //{
        //    Dictionary<string, object> par = new Dictionary<string, object>(6);
        //    par.Add("Order_ID", prOrder.Order_ID);
        //    //par.Add("Camera_EquipmentEquipment_ID", prOrder.Camera_EquipmentEquipment_ID);
        //    par.Add("CustomerName", prOrder.CustomerName);
        //    par.Add("CustomerEmail", prOrder.CustomerEmail);
        //   // par.Add("Quanity", prOrder.Quanity);
        //   // par.Add("Purchase_Price", prOrder.Purchase_Price);
        //    par.Add("Date_Purchased", prOrder.Date_Purchased);
        //    par.Add("ContactNumber", prOrder.ContactNumber);

        //    return par;
        //}

            // gets orders
        public List<clsOrder> GetOrder()
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM orders", null);
            List<clsOrder> lcOrders = new List<clsOrder>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add(dataRow2Orders(dr));
            return lcOrders;

        }
        // Was called work as I followed tutorial 3 
        private clsCameraequipment dataRow2AllWork(DataRow prDataRow)
        {
            return new clsCameraequipment()
            {
                Brand_Name = Convert.ToString(prDataRow["Brand_Name"]),
                Model = Convert.ToString(prDataRow["Model"]),
                Price = Convert.ToInt32(prDataRow["Price"]),
               // Quantity = Convert.ToString(prDataRow["Quantity"]),
                DateLastModified = Convert.ToDateTime(prDataRow["DateLastModified"]),
                Weight = Convert.ToString(prDataRow["Weight"]),
                MaxAperture = Convert.ToString(prDataRow["MaxAperture"]),
                // MaxAperture = prDataRow["MaxAperture"] is DBNull ? (string?)null : Convert.ToString(prDataRow["MaxAperture"]),
                Megapixels = prDataRow["MegaPixels"] is DBNull ? (int?)null : Convert.ToInt32(prDataRow["MegaPixels"]),
                FocalLength = prDataRow["FocalLength"] is DBNull ? (int?)null : Convert.ToInt32(prDataRow["FocalLength"]),
                EquipmentType = Convert.ToChar(prDataRow["EquipmentType"])

            };

        }

        private clsOrder dataRow2Orders(DataRow prDataRow)
        {

            return new clsOrder()
            {
                Order_ID = Convert.ToInt32(prDataRow["Order_ID"]),
                Camera_EquipmentEquipment_ID = Convert.ToInt16(prDataRow["Camera_EquipmentEquipment_ID"]),
                CustomerName = Convert.ToString(prDataRow["CustomerName"]),
                CustomerEmail = Convert.ToString(prDataRow["CustomerEmail"]),
                Quanity = Convert.ToInt32(prDataRow["Quanity"]),
                Purchase_Price = Convert.ToDecimal(prDataRow["Purchase_Price"]),
                Date_Purchased = Convert.ToDateTime(prDataRow["Date_Purchased"]),
                ContactNumber = Convert.ToInt32(prDataRow["ContactNumber"])


            };
        }


        public string PutCameras(clsCameraequipment prCameraEquipment)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "UPDATE camera_equipment SET Speciality = @Brand_Name, @Model, @Price, @Quantity, @DateLastModified, @Weight, @MaxAperture, @MegaPixels, FocalLength, EquipmentType",
                    prepareCameraEquipmentParameters(prCameraEquipment));
                if (lcRecCount == 1)
                    return "Equipment updated";
                else
                    return "Unexpected equipment update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }

        }
        public string PostCameras(clsCameraequipment prCameraEquipment)
        {   
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "INSERT INTO camera_equipment (Brand_Name, Model, Price, Quantity, DateLastModified, Weight, MaxAperture, MegaPixels, FocalLength, EquipmentType)" +
                    "VALUES (@Brand_Name, @Model, @Price, @Quantity, @DateLastModified, @Weight, @MaxAperture, @MegaPixels, @FocalLength, @EquipmentType)",


                    prepareCameraEquipmentParameters(prCameraEquipment));
                if (lcRecCount == 1)
                    return "Equipment updated";
                else
                    return "Unexpected equipment update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }


        public string DeleteEquipment(string Name)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
                    "DELETE FROM camera_equipment WHERE EquipmentID = @EquipmentID",
                   prepareCameraEquipmentParameters(Name));
                if (lcRecCount == 1)
                    return "One Equipment deleted";
                else
                    return "Unexpected Equipment delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }

        }

    }




}
