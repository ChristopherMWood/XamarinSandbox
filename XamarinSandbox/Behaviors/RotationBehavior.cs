using Xamarin.Forms;

namespace XamarinSandbox.Behaviors
{
    public class RotationBehavior : Behavior<ImageButton>
    {
        private bool animating = true;

        protected async override void OnAttachedTo(ImageButton bindable)
        {
            base.OnAttachedTo(bindable);

            while (animating)
            {
                await bindable.RotateTo(360, 5000, Easing.Linear);
                await bindable.RotateTo(0, 0);
            }
        }

        protected override void OnDetachingFrom(ImageButton bindable)
        {
            base.OnDetachingFrom(bindable);
            animating = false;
        }
    }
}
