using Xamarin.Forms;

namespace XamarinSandbox.Behaviors
{
    public class CartmanBehavior : Behavior<Image>
    {
        private bool animating = true;

        protected async override void OnAttachedTo(Image bindable)
        {
            base.OnAttachedTo(bindable);

            while (animating)
            {
                uint shakeLength = 100;
                uint walkRotation = 5;

                //walking
                bindable.Source = "cartman_happy";
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);


                //pointing and laughing
                bindable.Source = "cartman_pointing";
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);


                //walking
                bindable.Source = "cartman_happy";
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);


                //angry
                bindable.Source = "cartman_angry";
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
                await bindable.RotateTo(walkRotation, shakeLength, Easing.SpringOut);
                await bindable.RotateTo(walkRotation * -1, shakeLength, Easing.CubicInOut);
            }
        }

        protected override void OnDetachingFrom(Image bindable)
        {
            base.OnDetachingFrom(bindable);
            animating = false;
        }
    }
}
