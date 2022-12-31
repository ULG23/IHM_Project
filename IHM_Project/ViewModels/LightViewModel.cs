using CommunityToolkit.Mvvm.ComponentModel;
using IHM_Project.Model;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media;

namespace IHM_Project.ViewModels
{
    [ObservableObject]
    public partial class LightViewModel
    {
        [ObservableProperty]
        private Bulb bulb1 = new Bulb();

        [ObservableProperty]
        private Bulb bulb2 = new Bulb();

        [ObservableProperty]
        private Bulb bulb3 = new Bulb();

        [ObservableProperty]
        private Bulb bulb4 = new Bulb();

        [ObservableProperty]
        private Bulb bulb5 = new Bulb();

        [ObservableProperty]
        private Bulb bulb6 = new Bulb();

        public LightViewModel()
        {
            bulb1.Color = new SolidColorBrush(Colors.Gray);
            bulb2.Color = new SolidColorBrush(Colors.Gray);
            bulb3.Color = new SolidColorBrush(Colors.Gray);
            bulb4.Color = new SolidColorBrush(Colors.Gray);
            bulb5.Color = new SolidColorBrush(Colors.Gray);
            bulb6.Color = new SolidColorBrush(Colors.Gray);
        }

    }
}
