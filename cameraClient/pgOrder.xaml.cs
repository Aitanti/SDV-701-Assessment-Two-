using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace cameraClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgOrder : Page
    {

        protected clsCameraequipment _Equipment;
        public pgOrder()
        {
            this.InitializeComponent();
        }

        //private virtual void updateForm()
        //{
        //    tbBrand.Text = _Equipment.Brand_Name;
        //    tbEquipmentID.Text = _Equipment.EquipmentID.ToString();
        //    tbProductOrdered.Text = _Equipment.Model;
        //    tbTotalPrice.Text = _Equipment.Price.ToString();
        //    tbDatePurchased.Text = _Equipment.DateLastModified.ToShortDateString();
        //}




        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(pgMain), null);
        }

        private void TbProductOrdered_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
