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
        Result.Text = Randomise(3);
    }

    private void Button4_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(5);
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(7);
    }

    private void Button8_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(9);
    }

    private void Button10_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(11);
    }

    private void Button20_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(21);
    }

    private void Button100_Clicked(object sender, EventArgs e)
    {
        Result.Text = Randomise(101);
    }
}

