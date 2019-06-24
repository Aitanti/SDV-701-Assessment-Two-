using System;

using System.Windows.Forms;

namespace camerashop
{
    public sealed partial class frmMain : Form
    {

        private static readonly frmMain _Instance = new frmMain();
        private frmOrders frmOrders;

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void btnOrders_Click(object sender, EventArgs e)
        //{
        //    frmOrders.Instance.Show();
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
        private void lstbrands_DoubleClick(object sender, EventArgs e)
        {
            string lcKey = Convert.ToString(lstbrands.SelectedItem);

            try
            {
                /*_ArtistList.EditArtist(lcKey);
                updateDisplay();*/
                frmcameras.Run(lcKey);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Error");
            }

        }


        public async void UpdateDisplay()
        {
            lstbrands.DataSource = null;
            lstbrands.DataSource = await ServiceClient.GetCameraNamesAsync();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

            try
            {
                frmOrders = new frmOrders();
                frmOrders.Show();
            }

            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }


    }
}
