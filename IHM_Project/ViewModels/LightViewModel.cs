using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IHM_Project.Model;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IHM_Project.ViewModels
{
    [ObservableObject]
    public partial class LightViewModel
    {

        private int animationCounter = 0;

        DispatcherTimer timer = new DispatcherTimer();

        [ObservableProperty]
        private Bulb bulb1 = new();

        [ObservableProperty]
        private Bulb bulb2 = new();

        [ObservableProperty]
        private Bulb bulb3 = new();

        [ObservableProperty]
        private Bulb bulb4 = new();

        [ObservableProperty]
        private Bulb bulb5 = new();

        [ObservableProperty]
        private Bulb bulb6 = new();

        [ObservableProperty]
        private List<Bulb> bulbs = new();

        public IRelayCommand AnimationBlinkCommand { get; }

        public IRelayCommand AnimationFadeCommand { get; }
        public IRelayCommand AnimationMergeCommand { get; }
        public IRelayCommand AnimationF1Command { get; }

        public LightViewModel()
        {



            bulbs.Add(bulb1);
            bulbs.Add(bulb2);
            bulbs.Add(bulb3);
            bulbs.Add(bulb4);
            bulbs.Add(bulb5);
            bulbs.Add(bulb6);
            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Gray);
            }

            AnimationFadeCommand = new RelayCommand(AnimationFade);
            AnimationBlinkCommand = new RelayCommand(AnimationBlink);
            AnimationMergeCommand = new RelayCommand(AnimationMerge);
            AnimationF1Command = new RelayCommand(AnimationF1);

            
        }

        private void AnimationBlink()
        {
            timer.Tick += new EventHandler<object>(UpdateTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Start();

            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Blue);
            }

            if (bulbs[1].Color == new SolidColorBrush(Colors.Blue))
            {
                for (int i = 0; i < bulbs.Count; i++)
                {
                    bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                }
            }
        }

        private void AnimationFade()
        {
            timer.Tick += new EventHandler<object>(UpdateTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Start();

            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Blue);
            }


            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Orange);
            }
        }

        private void AnimationMerge()
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Green);
            }

        }

        private void AnimationF1()
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].Color = new SolidColorBrush(Colors.Red);
            }

        }

        private void UpdateTimer_Tick(object sender, object e)
        {

            while (animationCounter < 5)
            {
                animationCounter++;
            }
            animationCounter = 0;
        }
    }
}
