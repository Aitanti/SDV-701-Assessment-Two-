using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camerashop
{
    public partial class frmAllEquipment : Form
    {

        protected clsCameraequipment _Equipment;

        public delegate void LoadWorkFormDelegate(clsCameraequipment prCameraEquipment);
        public static Dictionary<char, Delegate> _EquipmentForm = new Dictionary<char, Delegate>
        {
            {'B', new LoadWorkFormDelegate(frmBody.Run)},
            {'L', new LoadWorkFormDelegate(frmLens.Run)}
        };

        public frmAllEquipment()
        {
            InitializeComponent();
        }

        public static void DispatchWorkForm(clsCameraequipment prCameraEquipment)
        {
            _EquipmentForm [prCameraEquipment.EquipmentType].DynamicInvoke(prCameraEquipment);
        }

        protected virtual void updateForm()
        {
            txtbrand.Text = _Equipment.Brand_Name;
            txtmodel.Text = _Equipment.Model;
            txtprice.Text = _Equipment.Price.ToString();
            txtqty.Text = _Equipment.Quantity;
            txtdatemodified.Text = _Equipment.DateLastModified.ToShortDateString();
        }   


       protected virtual void pushData()
        {
            _Equipment.Brand_Name = txtbrand.Text;
            _Equipment.Model = txtmodel.Text;
            _Equipment.Price = int.Parse (txtprice.Text);
            _Equipment.Quantity = txtqty.Text;
            _Equipment.DateLastModified = DateTime.Parse(txtdatemodified.Text);
        }

        public void SetDetails(clsCameraequipment prEquipment)
        {
            _Equipment = prEquipment;
            updateForm();
            ShowDialog();
        }
        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                pushData();
                if (txtbrand.Enabled)
                    MessageBox.Show(await ServiceClient.InsertCameraAsync(_Equipment));
                else
                    MessageBox.Show(await ServiceClient.UpdateCameraAsync(_Equipment));
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public virtual bool IsValid()
        {
            return true;
        }

      
    }
}
