using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace camerashop
{
    public partial class frmLens : camerashop.frmAllEquipment
    {

        public static readonly frmLens Instance =
            new frmLens();

        private frmLens()
        {
            InitializeComponent();
        }

        public static void Run(clsCameraequipment prLens)
        {
            Instance.SetDetails(prLens);
        }

        protected override void updateForm()
        {
            base.updateForm();
            txtfocal.Text = _Equipment.FocalLength.ToString();
            txtaperture.Text = _Equipment.MaxAperture;

        }
        protected override void pushData()
        {
            base.pushData();
            _Equipment.FocalLength = int.Parse(txtfocal.Text);
            _Equipment.MaxAperture = txtaperture.Text;
            

        }
    }
}
