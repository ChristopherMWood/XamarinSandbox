
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class ComplexAnimation : ContentPage
    {
        private bool animating = true;

        public ComplexAnimation()
        {
            InitializeComponent();
            Task.Run(() => AnimatePlane());
        }

        private async Task AnimatePlane()
        {
            await explosion.FadeTo(0, 0);

            while (animating)
            {
                _ = aircraft.RotateTo(10, 1000, Easing.CubicInOut);
                await aircraft.TranslateTo(100, 0, 2000, Easing.CubicInOut);

                _ = explosion.FadeTo(1, 100);
                _ = aircraft.RotateTo(-750, 1500);
                _ = explosion.FadeTo(1, 750);
                await aircraft.TranslateTo(-100, 100, 2000, Easing.CubicInOut);
                _ = explosion.FadeTo(0, 100);

                _ = aircraft.RotateTo(-700, 1500);
                await aircraft.TranslateTo(0, 0, 2000, Easing.CubicInOut);

                await aircraft.RotateTo(0, 1000, Easing.CubicInOut);
                await aircraft.TranslateTo(0, 0, 2000, Easing.CubicInOut);
            }
        }
    }
}
