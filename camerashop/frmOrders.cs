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
    public sealed partial class frmOrders : Form
    {

        public frmOrders()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            
            
                lstOrders.DataSource = null;
                List<clsOrder> lcOrders = await ServiceClient.GetOrdersAsync();
                lstOrders.DataSource = lcOrders;
            
         
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
