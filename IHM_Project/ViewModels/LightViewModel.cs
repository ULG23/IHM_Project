using CommunityToolkit.Mvvm.ComponentModel;
using IHM_Project.Model;

namespace IHM_Project.ViewModels
{
    [ObservableObject]
    public partial class LightViewModel
    {
        [ObservableProperty]
        private Bulb bulb1;

        [ObservableProperty]
        private Bulb bulb2;

        [ObservableProperty]
        private Bulb bulb3;

        [ObservableProperty]
        private Bulb bulb4;

        [ObservableProperty]
        private Bulb bulb5;

        [ObservableProperty]
        private Bulb bulb6;

    }
}
