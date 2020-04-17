using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class Buttons : ContentPage
    {
        public Buttons()
        {
            InitializeComponent();
        }

        public async void ButtonOneClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.ScaleTo(0.9, 500, Easing.CubicInOut);
            await button.ScaleTo(1.25, 500, Easing.Linear);
            await button.ScaleTo(1, 500, Easing.BounceOut);
        }

        public async void ButtonTwoClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.ScaleXTo(0.9, 500, Easing.CubicInOut);
            await button.ScaleXTo(1, 500, Easing.CubicInOut);
        }

        public async void ButtonThreeClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.RotateXTo(360, 750, Easing.SinInOut);
            await button.RotateXTo(0, 0);
        }

        public async void ButtonFourClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.FadeTo(0, 500, Easing.CubicInOut);
            await button.FadeTo(1, 500, Easing.CubicInOut);
        }

        public async void ButtonFiveClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            _ = button.ScaleTo(0.5, 400, Easing.CubicIn);
            await button.RotateTo(360 * 10, 2000, Easing.CubicIn);
            _ = button.RotateTo(360 * 2, 200);
            _ = button.ScaleTo(1, 400, Easing.CubicOut);
        }

        public async void OnButtonSixPress(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.ScaleTo(0.9, 200, Easing.CubicInOut);
        }

        public async void ButtonSixClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            await button.ScaleTo(1, 500, Easing.BounceOut);
        }
    }
}
