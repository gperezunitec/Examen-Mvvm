using Examen_Mvvm.ViewModels;

namespace Examen_Mvvm.Views;

public partial class MainView : ContentPage
{
	
	private MainViewModels viewModel;
	public MainView()
	{
		InitializeComponent();
		viewModel = new MainViewModels();
		BindingContext = viewModel;

	}
}