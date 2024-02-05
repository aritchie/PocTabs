namespace PocTabs;

public partial class OnePage : ContentPage
{
	public OnePage()
	{
		InitializeComponent();
        this.BindingContext = this;
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();
        this.Appeared = this.Appeared + 1;
    }


    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        this.Disappeared = this.Disappeared + 1;
    }


    int appeared;
    public int Appeared
    {
        get => appeared;
        set
        {
            appeared = value;
            this.OnPropertyChanged();
        }
    }


    int disappear;
    public int Disappeared
    {
        get => disappear;
        set
        {
            disappear = value;
            this.OnPropertyChanged();
        }
    }
}
