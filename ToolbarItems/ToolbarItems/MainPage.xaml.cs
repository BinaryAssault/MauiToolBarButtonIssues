namespace ToolbarItems;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if(string.Compare(TbGlyph, "\ue8dc") != 0)
		{
			TbGlyph = "\ue8dc";
        }
		else
		{
            TbGlyph = "\ue8db";
        }
	}

	private string _tbGlypgh = "\ue8dc";
	public string TbGlyph
	{
		get => _tbGlypgh;
		set
		{
			_tbGlypgh = value;
			OnPropertyChanged();
		}
	}
}

