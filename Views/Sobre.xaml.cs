namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();

		lbl_versao.Text = AppInfo.Current.VersionString;
	}

	private async void btn_voltar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
