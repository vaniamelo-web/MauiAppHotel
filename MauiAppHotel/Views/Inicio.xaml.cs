namespace MauiAppHotel.Views;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new SobreApp());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new Suites());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new Endereco());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}