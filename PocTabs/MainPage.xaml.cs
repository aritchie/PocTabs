namespace PocTabs;


public partial class MainPage : TabbedPage
{
    readonly Dictionary<Type, Page> pages = new();


	public MainPage()
	{
		this.InitializeComponent();
	}

    void btnOne_Clicked(object sender, EventArgs e)
    {
        this.Set(new OnePage());
    }

    void btnTwo_Clicked(object sender, EventArgs e)
    {
        this.Set(new TwoPage());
    }


    void Set(Page page)
    {
        var pt = page.GetType();

        // fully works but loses state
        this.Children[2] = new NavigationPage(page);
        this.SelectedItem = this.Children[2];

        // loses events, back crashes on android
        //if (this.pages.ContainsKey(pt))
        //{
        //    this.Children[2] = this.pages[pt];
        //}
        //else
        //{
        //    var nav = new NavigationPage(page);
        //    this.Children[2] = nav;
        //    this.pages.Add(pt, nav);
        //}
        //this.SelectedItem = this.Children[2];

        // this works perfectly on iOS, but still crashes on android back
        this.Children.RemoveAt(2);
        if (this.pages.ContainsKey(pt))
        {
            this.Children.Add(this.pages[pt]);
        }
        else
        {
            var nav = new NavigationPage(page);
            this.Children.Add(nav);
            this.pages.Add(pt, nav);
            //this.pages.Add(pt, page);
            //this.Children.Add(page);
        }
        this.SelectedItem = this.Children[2];
    }
}