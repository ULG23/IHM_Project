using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM_Project.Model
{
    [ObservableObject]
    public partial class Animation
    {
        [ObservableProperty]
        public int index;

        [ObservableProperty]
        public string? name;
    }
}
