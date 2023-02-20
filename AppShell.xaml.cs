using MauiGrouping.Pages;

namespace MauiGrouping;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AnimalsPage), typeof(AnimalsPage));

	}
}
