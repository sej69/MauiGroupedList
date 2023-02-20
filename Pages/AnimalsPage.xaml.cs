using MauiGrouping.ViewModels;

namespace MauiGrouping.Pages;

public partial class AnimalsPage : ContentPage
{
	AnimalsViewModel _vm;

	public AnimalsPage( AnimalsViewModel vm )
	{
		InitializeComponent();

		_vm = vm;

		BindingContext= _vm;

		_vm.LoadData();
	}
}