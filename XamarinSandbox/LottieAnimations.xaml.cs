using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class LottieAnimations : ContentPage
    {
        public List<Slide> LottieSlides { get; set; }

        public LottieAnimations()
        {
            Title = "Lottie Animations";
            InitializeComponent();

            LottieSlides = new List<Slide>()
            {
                new Slide
                {
                    Title = "Covid-19 is here",
                    AnimationFilename = "covid_19.json",
                    Info = "To beat this disease you have to be prepared..."
                },
                new Slide
                {
                    Title = "Use Hand Sanitizer",
                    AnimationFilename = "hand_sanitizer.json",
                    Info = "If you have access to some, use it."
                },
                new Slide
                {
                    Title = "Wash Your Hands",
                    AnimationFilename = "wash_hands.json",
                    Info = "You need to wash your hands as much as possible."
                },
                new Slide
                {
                    Title = "Look Like a Surgeon",
                    AnimationFilename = "wear_mask.json",
                    Info = "You want to act like it's halloween every day of the year? Well you're in luck."
                },
                new Slide
                {
                    Title = "Stay Home",
                    AnimationFilename = "stay_home.json",
                    Info = "To flatten the curve you need to do your part."
                },
            };

            BindingContext = this;
        }
    }

    public class Slide
    {
        public string Title { get; set; }
        public string AnimationFilename { get; set; }
        public string Info { get; set; }
    }
}
