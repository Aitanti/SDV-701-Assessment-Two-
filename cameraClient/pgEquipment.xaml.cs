using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace cameraClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class pgEquipment : Page
    {
        public pgEquipment()
        {
            InitializeComponent();
        }

        private static Dictionary<string, pgEquipment> _EquipmentPageList = new Dictionary<string, pgEquipment>();

        private clsBrand _Brand;

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            UpdateForm();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            try
            {
                _Brand.BrandName = tbBrandName.Text;
                

               lstquipment.ItemsSource = null;
                if (_Brand.CameraList != null)
                    lstquipment.ItemsSource = _Brand.CameraList;
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.Message.ToString();
            }
        }

        public void UpdateForm()
        {
            try
            {
                tbBrandName.Text = _Brand.BrandName;
               
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.Message.ToString();
            }
        }

        private async void refreshFormFromDB(string prBrandName)
        {
            SetDetails(await ServiceClient.GetCameraAsync(prBrandName));
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcBrandName = e.Parameter.ToString();

                try
                {
                    _Brand = await ServiceClient.GetCameraAsync(lcBrandName);
                }
                catch (Exception lcEx)
                {
                    tbMessages.Text = lcEx.Message.ToString();
                }

                UpdateForm();
                UpdateDisplay();
            }
            else
                _Brand = new clsBrand();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(pgMain), null);
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //private void BtnOrder_Click(object sender, RoutedEventArgs e)
        //{
        //    int lcIndex = lstquipment.SelectedIndex;
        //    if (lcIndex >= 0)
        //        this.Frame.Navigate(typeof(pgOrder), lstquipment.SelectedItem);
        //}

        private void Lstquipment_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(pgOrder));

        }
    }
}
