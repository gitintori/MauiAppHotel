using System.Collections.ObjectModel;

namespace MauiAppHotel
{
    public partial class FotosHotel : ContentPage
    {
        public ObservableCollection<ImageItem> Images { get; set; }

        public FotosHotel()
        {
            InitializeComponent();

            Images = new ObservableCollection<ImageItem>
            {
                new ImageItem { Source = "suitesuperluxo.jpg", Title = "Suite Super Luxo" },
                new ImageItem { Source = "suiteluxo.jpg", Title = "Suite Luxo" },
                new ImageItem { Source = "suitesingle.jpg", Title = "Suite Single" },
                new ImageItem { Source = "suiteeconomica.jpg", Title = "Suite Econômica" }
            };

            BindingContext = this;
        }

        public class ImageItem
        {
            public string? Source { get; set; }
            public string? Title { get; set; }
        }

        private async void OnButtonVoltarClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}
