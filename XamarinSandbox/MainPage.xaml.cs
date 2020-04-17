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

        public async void AnimationsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleAnimations());
        }

        public async void LottieButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LottieAnimations());
        }

        public async void ButtonsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Buttons());
        }

        public async void ComplexAnimationButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComplexAnimation());
        }
    }
}
