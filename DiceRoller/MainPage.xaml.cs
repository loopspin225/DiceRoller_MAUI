namespace DiceRoller;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    public string Randomise(int value)
    {
        var rand = new Random();
        int randValue = 0;
        while(randValue <= 0)
        {
            randValue = rand.Next(value);
        }
        string randResult = randValue.ToString();
        return randResult;
    }

    private void Button2_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(2);
    }

    private void Button4_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(4);
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(6);
    }

    private void Button8_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(8);
    }

    private void Button10_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(10);
    }

    private void Button20_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(20);
    }

    private void Button100_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(100);
    }
}

