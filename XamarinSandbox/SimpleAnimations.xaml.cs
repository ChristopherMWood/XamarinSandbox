using System;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class SimpleAnimations : ContentPage
    {
        public SimpleAnimations()
        {
            this.Title = "Basketball Animation";
            InitializeComponent();
        }

        public async void OnStartAnimationOne(object sender, EventArgs e)
        {
            _ = basketball_image.RotateTo(360, 3000, Easing.SinInOut);
            _ = basketball_image.TranslateTo(200, 100, 3000, Easing.SinInOut);
        }

        public async void OnStartAnimationTwo(object sender, EventArgs e)
        {
            _ = basketball_image.RotateTo(360, 3000, Easing.SinInOut);
            _ = basketball_image.TranslateTo(200, 100, 3000, Easing.SinInOut);
        }

        public async void OnStartAnimationThree(object sender, EventArgs e)
        {
            _ = basketball_image.RotateTo(360, 3000, Easing.SinInOut);
            _ = basketball_image.TranslateTo(200, 100, 3000, Easing.SinInOut);
        }
    }
}
