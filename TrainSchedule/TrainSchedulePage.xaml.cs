using Xamarin.Forms;

namespace TrainSchedule
{
    public partial class TrainSchedulePage : ContentPage
    {
        public TrainSchedulePage()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {

            }
            else if (Device.RuntimePlatform == Device.iOS)
            {

            }


            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                case Device.Android:
                    Padding = new Thickness(0);
                    break;
             
            }
        }
    }
}   
