using TP03;

namespace TP03;
//Isabelly Barbosa Gonçalves
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new PackageViewModel();
	}
}

