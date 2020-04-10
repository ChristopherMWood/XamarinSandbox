using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinSandbox
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnSettingsClicked(object sender, EventArgs e)
        {
        }

        public void AnimationsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleAnimations());
        }

        public void LottieButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LottieAnimations());
        }
    }
}
