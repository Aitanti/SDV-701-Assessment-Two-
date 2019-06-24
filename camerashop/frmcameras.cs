using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace camerashop
{
    public partial class frmcameras : Form
    {
        private clsBrand _Brand;
        private clsCameraequipment _EquipmentType;

        private static Dictionary<string, frmcameras> _BrandFormList =
            new Dictionary<string, frmcameras>();

        public frmcameras()
        {
            InitializeComponent();
        }

        public static void Run(string prBrandName)
        {
            frmcameras lcBrandForm;
            if ((string.IsNullOrEmpty(prBrandName) || !_BrandFormList.TryGetValue(prBrandName, out lcBrandForm)))
            {
                lcBrandForm = new frmcameras();
                if (string.IsNullOrEmpty(prBrandName))
                    lcBrandForm.SetDetails(new clsBrand());
                else
                {
                    _BrandFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            }
            else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }
        }

       private async void refreshFormFromDB(string  prBrandName)
        {
            SetDetails(await ServiceClient.GetCameraAsync(prBrandName));
        }

        private void updateForm()
        {
            txtBrand.Text = _Brand.BrandName;
            txtSlogan.Text = _Brand.Slogan;
          
            //if (_CameraEquipment.CameraEquipmentList != null)
            //    lstEquipment.DataSource = _CameraEquipment.CameraEquipment;
            /*    lblTotal.Text = Convert.ToString(_Artist.TotalValue);
                       _WorksList = _Artist.WorksList;*/
        }

        //private void updateTitle(string prGalleryName)
        //{
        //    if (!string.IsNullOrEmpty(prGalleryName))
        //        Text = "Artist Details - " + prGalleryName;
        //}
        private void updateDisplay()
        {
            txtBrand.Enabled = txtBrand.Text == "";
            txtSlogan.Enabled = txtSlogan.Text == "";
            lstEquipment.DataSource = null;
            if (_Brand.CameraList != null)
                 lstEquipment.DataSource = _Brand.CameraList;
        }

            public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            updateForm();
            updateDisplay();
            Show();
            
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new frmQuestion (clsCameraequipment.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply)) // not cancelled?
                {
                    clsCameraequipment lcEquipment = clsCameraequipment.NewCameraEquipment(lcReply[0]);
                    if (lcEquipment != null) // valid artwork created?
                    {
                        frmAllEquipment.DispatchWorkForm(lcEquipment);
                        lcEquipment.Brand_Name = _Brand.BrandName;
                        lcEquipment.EquipmentType = lcReply[0];
                        refreshFormFromDB(_Brand.BrandName);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lstEquipment_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstEquipment.SelectedIndex;
            try
            {
                frmAllEquipment.DispatchWorkForm(lstEquipment.SelectedValue as clsCameraequipment);
                updateDisplay();

            }
            catch(Exception)
            {

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int lcIndex = lstEquipment.SelectedIndex;

                if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(await ServiceClient.DeleteEquipmentAsync(lstEquipment.SelectedItem as clsCameraequipment));
                    refreshFormFromDB(_EquipmentType.Model);
                }
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }


    }
    }


  

