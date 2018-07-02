using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Phoneword.Service;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QrcodePage : ContentPage
    {
        public QrcodePage()
        {
            InitializeComponent();
        }

        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                if (scanner != null)
                {
                    var result = await scanner.ScanAsync();
                    if (result != "")
                    {
                        txtShow.Text = result;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}