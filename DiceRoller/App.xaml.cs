
namespace DiceRoller;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var mainWindow = base.CreateWindow(activationState);

		const int width = 500;
		const int height = 650;

		mainWindow.Width = width;
		mainWindow.Height = height;

		mainWindow.MaximumWidth = width;
		mainWindow.MaximumHeight = height;

        mainWindow.MinimumWidth = width;
        mainWindow.MinimumHeight = height;

        return mainWindow;
    }
}
