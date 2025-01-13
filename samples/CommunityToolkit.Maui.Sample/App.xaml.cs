using Application = Microsoft.Maui.Controls.Application;

namespace CommunityToolkit.Maui.Sample;

public partial class App : Application
{
	readonly AppShell appShell;

	public App(AppShell appShell)
	{
		InitializeComponent();

		this.appShell = appShell;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
		Application.Current.UserAppTheme = AppTheme.Dark;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
	}

	protected override Window CreateWindow(IActivationState? activationState) => new(appShell);
}