using CommunityToolkit.Maui.Views;
using Particle.Maui;
namespace DeltaMauiScanner;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
        Score.Text = Globals.totalpoints.ToString();
        Globals.totalpoints= 0;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Close();
    }

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //    MyParticleCanvas.IsRunning = true;
    //}

    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();

    //    MyParticleCanvas.IsRunning = false;
    //}
}