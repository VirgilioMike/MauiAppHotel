namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		pck_quarto.ItemsSource = new List<string>
		{
			"Suíte Super Luxo",
			"Suíte Luxo",
			"Suíte Single",
			"Suíte Crianças"
		};

		dtpck_checkin.MinimumDate = DateTime.Today;
		dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
		dtpck_checkout.Date = DateTime.Today.AddDays(1);
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		// O check-out precisa ser pelo menos um dia depois do check-in
		DateTime data_minima_checkout = ((DateTime)e.NewDate).AddDays(1);

		dtpck_checkout.MinimumDate = data_minima_checkout;

		if (dtpck_checkout.Date < data_minima_checkout)
			dtpck_checkout.Date = data_minima_checkout;
	}

	private async void btn_sobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}
