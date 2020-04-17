using Xamarin.Forms;

namespace XamarinSandbox.Behaviors
{
    public class BellShakeBehavior : Behavior<Image>
    {
        private bool animating = true;

        protected async override void OnAttachedTo(Image bindable)
        {
            base.OnAttachedTo(bindable);

            while (animating)
            {
                //await bindable.TranslateTo(10, 0, 100, Easing.SpringOut);
                //await bindable.TranslateTo(0, 0, 100, Easing.SpringIn);
                //await bindable.TranslateTo(-10, 0, 100, Easing.SpringOut);
                //await bindable.TranslateTo(0, 0, 100, Easing.SpringIn);
                uint shakeLength = 50;
                await bindable.RotateTo(10, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(-10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(-10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(-10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(-10, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(0, shakeLength, Easing.SpringIn);
                await bindable.RotateTo(0, 3000, Easing.Linear);
            }
        }

        protected override void OnDetachingFrom(Image bindable)
        {
            base.OnDetachingFrom(bindable);
            animating = false;
        }
    }
}
