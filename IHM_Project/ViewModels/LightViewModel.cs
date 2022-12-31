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
using System.Runtime.InteropServices.ObjectiveC;

namespace IHM_Project.ViewModels
{
    [ObservableObject]
    public partial class LightViewModel
    {

        int tick = 0;
        ListView ListView = new ListView();
        DispatcherTimer timerBlink = new DispatcherTimer();
        DispatcherTimer timerF1 = new DispatcherTimer();
        DispatcherTimer timerFade = new DispatcherTimer();
        DispatcherTimer timerMerge = new DispatcherTimer();

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
            timerBlink.Tick += new EventHandler<object>(UpdateTimerBlink_Tick);
            timerBlink.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timerF1.Tick += new EventHandler<object>(UpdateTimerF1_Tick);
            timerF1.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timerMerge.Tick += new EventHandler<object>(UpdateTimerMerge_Tick);
            timerMerge.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timerFade.Tick += new EventHandler<object>(UpdateTimerFade_Tick);
            timerFade.Interval = new TimeSpan(0, 0, 0, 0, 200);

            AnimationBlinkCommand = new RelayCommand(AnimationBlink);
            AnimationFadeCommand = new RelayCommand(AnimationFade);
            AnimationMergeCommand = new RelayCommand(AnimationMerge);
            AnimationF1Command = new RelayCommand(AnimationF1);

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
            this.tick = 0;

            timerBlink.Start();

        }

        private void AnimationFade()
        {
            this.tick = 0;

            timerFade.Start();
        }


        private void AnimationMerge()
        {

            this.tick = 0;

            timerMerge.Start();
        }
        private void AnimationF1()
        {
            this.tick = 0;
            ListView.Items.Add("Animation  F1");

            timerF1.Start();
        }

        private void UpdateTimerFade_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled || !timerBlink.IsEnabled || !timerMerge.IsEnabled)
            {
                tick = tick + 1;

                for (int k = 0;k < 6; k++)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        if (tick == (2 + i) + 6 * k)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Orange);
                        }
                        if (tick == (3 + i) + 6* k)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                        }
                    }
                }

                if (tick > 25)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                    }
                    timerFade.Stop();
                }
            }
        }

        private void UpdateTimerMerge_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled || !timerFade.IsEnabled || !timerBlink.IsEnabled)
            {
                tick = tick + 1;
                for (int k = 0; k < 2; k++)
                {
                    for (int i = 0; i < (bulbs.Count / 2); i++)
                    {
                        if (tick == 4 * k + 2 + i)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Green);
                            bulbs[bulbs.Count - (i + 1)].Color = new SolidColorBrush(Colors.Green);
                        }
                        if (tick == 4 * k + 3 + i)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                            bulbs[bulbs.Count - (i + 1)].Color = new SolidColorBrush(Colors.Gray);
                        }
                    }
                }
                if (tick > 8)
                {
                    if (tick % 2 != 0)
                    {
                        for (int i = 0; i < bulbs.Count; i++)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Green);
                        }

                    }

                    if (tick % 2 == 0)
                    {
                        for (int i = 0; i < bulbs.Count; i++)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                        }

                    }

                }
                if (tick > 14)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                    }
                    timerMerge.Stop();
                }


            }

        }

        private void UpdateTimerF1_Tick(object sender, object e)
        {
            if(!timerBlink.IsEnabled || !timerFade.IsEnabled || !timerMerge.IsEnabled )
            {
                tick = tick + 1;
                if (tick < 7)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        bulbs[i].Color = new SolidColorBrush(Colors.Black);
                    }
                }
                else
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        if (tick == 8 + 2 * i)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Red);
                        }
                    }
                }
                if (tick > 20) {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                    }
                    timerF1.Stop(); 
                }
            }

        }



        private void UpdateTimerBlink_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled || !timerFade.IsEnabled|| !timerMerge.IsEnabled)
            {

                tick = tick + 1;
                if (tick <= 8)
                {
                    if (tick % 2 != 0)
                    {
                        for (int i = 0; i < bulbs.Count; i++)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Blue);
                        }

                    }

                    if (tick % 2 == 0)
                    {
                        for (int i = 0; i < bulbs.Count; i++)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                        }

                    }
                }
                else timerBlink.Stop();
            }


            //while (animationCounter < 5)
            //{
            //    AnimationBlink();
            //    animationCounter++;
            //}
            //animationCounter = 0;
        }

    }
}
