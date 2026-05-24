namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
        DateTime dataCheckin = (DateTime)dtpck_checkin.Date;
        dtpck_checkout.MinimumDate = dataCheckin.AddDays(1);
        dtpck_checkout.MaximumDate = dataCheckin.AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try { 

        await Navigation.PushAsync(new SobreApp());
    
        }catch (Exception ex){
            DisplayAlert("Ops", ex.Message, "Ok");
}
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}