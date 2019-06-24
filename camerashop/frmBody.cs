using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace camerashop
{
    public partial class frmBody : camerashop.frmAllEquipment
    {
        public static readonly frmBody Instance =
            new frmBody();

        private frmBody()
        {
            InitializeComponent();
        }

        public static void Run(clsCameraequipment prBody)
        {
            Instance.SetDetails(prBody);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtweight.Text = _Equipment.Weight;
            txtmegapixels.Text = _Equipment.Megapixels.ToString();
        
        }
        protected override void pushData()
        {
            base.pushData();
            _Equipment.Weight = txtweight.Text;
            _Equipment.Megapixels = int.Parse(txtmegapixels.Text); 
        
        }
    }
}
