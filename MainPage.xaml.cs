namespace DPMO_U2_A1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void realizarConversion(object sender, EventArgs args)
	{
		double x = 0;
        int cantidadAConvertir = int.Parse(cantidad.Text);
        switch (divisa.SelectedIndex)
		{
			case 0:
				x = cantidadAConvertir * 19.92;
				break;
			case 1:
				x = cantidadAConvertir * 19.64;
                break;
			case 2:
                x = cantidadAConvertir * 22.59;
                break;
			case 3:
                x = cantidadAConvertir * 0.13;
                break;
			case 4:
                x = cantidadAConvertir * 0.32;
                break;
			default:
				x = 2 + 1;
				break;
		}
		respuesta.Text = $"{cantidad.Text} equivale a {x:0.##} {divisa.SelectedItem}";
	}
}

