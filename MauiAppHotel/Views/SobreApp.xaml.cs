namespace MauiAppHotel.Views;

public partial class SobreApp : ContentPage
{
	public SobreApp()
	{
	    InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}