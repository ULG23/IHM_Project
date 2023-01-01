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
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Threading.Tasks;

namespace IHM_Project.ViewModels
{
    [ObservableObject]
    public partial class LightViewModel
    {

        int tick = 0;
        int blinkIsRunning = 0;
        int fadeIsRunning = 0;
        int mergeIsRunning = 0;
        int F1IsRunning = 0;

        int[] animationsList = new int[] { 0 };


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

        [ObservableProperty]
        private List<Animation> listAnimation = new List<Animation>();

        public IRelayCommand AnimationBlinkCommand { get; }
        public IRelayCommand AnimationFadeCommand { get; }
        public IRelayCommand AnimationMergeCommand { get; }
        public IRelayCommand AnimationF1Command { get; }
        public IRelayCommand AnimationList1Command { get; }
        public IRelayCommand AnimationList2Command { get; }
        public IRelayCommand AnimationList3_1Command { get; }
        public IRelayCommand AnimationList3_2Command { get; }
        public IRelayCommand AnimationList3_3Command { get; }
        public IRelayCommand AnimationList3_4Command { get; }
        public IRelayCommand AnimationList3Command { get; }
        public IRelayCommand AnimationList4Command { get; }
        public IRelayCommand AnimationList5Command { get; }



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
            AnimationList1Command = new RelayCommand(AnimationList1);
            AnimationList2Command = new RelayCommand(AnimationList2);
            AnimationList3_1Command = new RelayCommand(AnimationList3_1);
            AnimationList3_2Command = new RelayCommand(AnimationList3_2);
            AnimationList3_3Command = new RelayCommand(AnimationList3_3);
            AnimationList3_4Command = new RelayCommand(AnimationList3_3);
            AnimationList3Command = new RelayCommand(AnimationList3);
            AnimationList4Command = new RelayCommand(AnimationList4);
            AnimationList5Command = new RelayCommand(AnimationList5);


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

        public void Play()
        {
            if (blinkIsRunning == 3)
            {
                timerBlink.Start();
                blinkIsRunning = 1;
            }

            if (fadeIsRunning == 3)
            {
                timerFade.Start();
                fadeIsRunning = 1;
            }

            if (F1IsRunning == 3)
            {
                timerF1.Start();
                F1IsRunning = 1;
            }

            if (mergeIsRunning == 3)
            {
                mergeIsRunning = 1;
                timerMerge.Start();
            }
        }
        public void Stop()
        {
            if (blinkIsRunning == 1)
            {
                timerBlink.Stop();
                blinkIsRunning = 3;
            }

            if (fadeIsRunning == 1)
            {
                timerFade.Stop();
                fadeIsRunning = 3;
            }

            if (F1IsRunning == 1)
            {
                timerF1.Stop();
                F1IsRunning = 3;
            }

            if (mergeIsRunning == 1)
            {
                timerMerge.Stop();
                mergeIsRunning = 3;
            }

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

            timerF1.Start();
        }

        private void AnimationList1()
        {
            animationsList = new int[] { 2, 3, 4 };
            AnimationBlink();
        }

        private void AnimationList2()
        {
            animationsList = new int[] { 3, 2, 1 };
            AnimationF1();
        }
        private void AnimationList3()
        {
            animationsList = new int[] { 4, 1, 2 };
            AnimationMerge();
        }
        private void AnimationList4()
        {
            animationsList = new int[] { 1, 4, 3 };
            AnimationFade();
        }
        private void AnimationList5()
        {
            animationsList = new int[] { 4,1,2 };
            AnimationMerge();
        }

        private void AnimationList3_1()
        {
            animationsList = new int[] { 2, 3 };
            AnimationBlink();
        }

        private void AnimationList3_2()
        {
            animationsList = new int[] { 4, 3 };
            AnimationMerge();
        }
        private void AnimationList3_3()
        {
            animationsList = new int[] { 1, 3 };
            AnimationF1();
        }
        private void AnimationList3_4()
        {
            animationsList = new int[] {1, 2 };
            AnimationMerge();
        }

        private void UpdateTimerFade_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled && !timerBlink.IsEnabled && !timerMerge.IsEnabled)
            {
                fadeIsRunning = 1;
                tick = tick + 1;

                for (int k = 0; k < 6; k++)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        if (tick == (2 + i) + 6 * k)
                        {
                            bulbs[i].Color = new SolidColorBrush(Colors.Orange);
                        }
                        if (tick == (3 + i) + 6 * k)
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
                    if (animationsList.Length != 0 && animationsList.First() == 1)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationBlink();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 2)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationFade();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 3)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationMerge();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 4)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationF1();
                    }
                }
            }

        }

        private void UpdateTimerMerge_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled && !timerFade.IsEnabled && !timerBlink.IsEnabled)
            {
                mergeIsRunning = 1;
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
                    mergeIsRunning = 2;
                    if (animationsList.Length != 0 && animationsList[0] == 1)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationBlink();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 2)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationFade();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 3)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationMerge();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 4)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationF1();
                    }

                }
            }

        }

        private void UpdateTimerF1_Tick(object sender, object e)
        {
            if (!timerBlink.IsEnabled && !timerFade.IsEnabled && !timerMerge.IsEnabled)
            {
                F1IsRunning = 1;
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
                if (tick > 20)
                {
                    for (int i = 0; i < bulbs.Count; i++)
                    {
                        bulbs[i].Color = new SolidColorBrush(Colors.Gray);
                    }
                    timerF1.Stop();
                    F1IsRunning = 2;
                    if (animationsList.Length != 0 && animationsList[0] == 1)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationBlink();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 2)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationFade();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 3)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationMerge();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 4)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationF1();
                    }
                }
            }


        }



        private void UpdateTimerBlink_Tick(object sender, object e)
        {
            if (!timerF1.IsEnabled && !timerFade.IsEnabled && !timerMerge.IsEnabled)
            {
                blinkIsRunning = 1;
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
                else
                {
                    timerBlink.Stop();
                    blinkIsRunning = 2;
                    if (animationsList.Length != 0 && animationsList[0] == 1)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationBlink();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 2)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationFade();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 3)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationMerge();
                    }
                    else if (animationsList.Length != 0 && animationsList[0] == 4)
                    {
                        animationsList = animationsList.Skip(1).ToArray();
                        AnimationF1();
                    }
                }

            }


        }


    }
}
