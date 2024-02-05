namespace PocTabs;

public partial class TwoPage : ContentPage
{
	public TwoPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new ThreePage());
    }
}
