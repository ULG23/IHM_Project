using CommunityToolkit.Mvvm.ComponentModel;
using GalaSoft.MvvmLight;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace IHM_Project.Model
{
    [ObservableObject]
    public partial class Bulb
    {
        [ObservableProperty]
        private Brush color ;

        public Bulb()
        {
            color = new SolidColorBrush(Colors.Red);
        }
    }
}
