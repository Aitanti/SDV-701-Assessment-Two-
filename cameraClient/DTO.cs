using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace cameraClient
{
    public class clsBrand
    {
        public string BrandName { get; set; }
        public string Slogan { get; set; }
        public List<clsCameraequipment> CameraList { get; set; }
        //public clsCameraequipment GetCamera(int prIndex)
        //{
        //    return CameraList[prIndex];
        //}

    }


    public class clsCameraequipment
    {
        public int EquipmentID { get; set; }
        public string Brand_Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Quantity { get; set; }
        public DateTime DateLastModified { get; set; }
        public string Weight { get; set; }
        public string MaxAperture { get; set; }
        public int? Megapixels { get; set; }
        public int? FocalLength { get; set; }
        public char EquipmentType { get; set; }

        public static readonly string FACTORY_PROMPT = "Enter L for Lens and B for Body";

        //public List<clsCameraequipment> CameraList { get; set; }
        public static clsCameraequipment NewCameraEquipment(char prEquipmentType)
        {
            return new clsCameraequipment() { EquipmentType = Char.ToUpper(prEquipmentType) };
        }
        public static clsCameraequipment NewWork(char prEquipmentType)
        {
            return new clsCameraequipment() { EquipmentType = Char.ToUpper(prEquipmentType) };
        }
        public override string ToString()
        {

            string lcString = "";
            if (EquipmentType == 'B')
                lcString = "Body";
            else
                lcString = "Lens";

            lcString = lcString + "\t" + Model + "\t" + Quantity;

            return lcString;

        }
    }

    public class clsOrder
    {
        public int? Order_ID { get; set; }
        public int? Camera_EquipmentEquipment_ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int Quanity { get; set; }
        public decimal Purchase_Price { get; set; }
        public DateTime? Date_Purchased { get; set; }
        public int ContactNumber { get; set; }

    }
}
