namespace Maui_databinding;

public partial class MiauBindeable : ContentPage
{
    public List<Char> letters = new List<char>();

    public List<Char> Letters
    {
        get => letters;
        set
        {
            letters = value;
            OnPropertyChanged();
        }
    }

	public MiauBindeable()
	{
		InitializeComponent();
        Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
        BindingContext = this;
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        ((Button)sender).IsEnabled = false;
    }

    private void BtnBomba_OnClicked(object sender, EventArgs e)
    {
        Letters = new List<char>();
    }
}