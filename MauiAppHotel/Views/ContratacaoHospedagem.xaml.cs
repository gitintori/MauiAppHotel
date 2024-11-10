namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void OnAvancarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HospedagemContratada());
    }

    private async void OnSobreButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
