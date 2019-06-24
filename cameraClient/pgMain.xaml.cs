using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace cameraClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            this.InitializeComponent();

            this.btnSelect.Click += BtnSelect_Click;
        }

        private async void LstBrands_Loaded(object sender, RoutedEventArgs e)
        {
            lstBrands.ItemsSource = await ServiceClient.GetCameraNamesAsync();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            int lcIndex = lstBrands.SelectedIndex;
            if (lcIndex >= 0)
                this.Frame.Navigate(typeof(pgEquipment), lstBrands.SelectedItem);
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstBrands.ItemsSource = await ServiceClient.GetCameraNamesAsync();
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog(ex.Message);
                await dialog.ShowAsync();
            }
        }

        private void LstBrands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
