using Syncfusion.Maui.Gauges;

namespace RadialGaugeBGImage;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void RadialAxis_LabelCreated(object sender, LabelCreatedEventArgs e)
    {
        if (e.Text == "90")
        {
            e.Text = "E";
        }
        else if (e.Text == "360")
        {
            e.Text = string.Empty;
        }
        else
        {
            if (e.Text == "0")
            {
                e.Text = "N";
            }
            else if (e.Text == "180")
            {
                e.Text = "S";
            }
            else if (e.Text == "270")
            {
                e.Text = "W";
            }
        }
    }
}

