using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace IHM_Project
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void buttonForALl_Click(object sender, RoutedEventArgs e)
        {
            if (buttonForAll.AccessKey.Equals("Off"))
            {
                lamp1.Fill = new SolidColorBrush(Colors.HotPink);
                lamp1.AccessKey = "On";
                lamp2.Fill = new SolidColorBrush(Colors.HotPink);
                lamp2.AccessKey = "On";
                lamp3.Fill = new SolidColorBrush(Colors.HotPink);
                lamp3.AccessKey = "On";
                lamp4.Fill = new SolidColorBrush(Colors.HotPink);
                lamp4.AccessKey = "On";
                lamp5.Fill = new SolidColorBrush(Colors.HotPink);
                lamp5.AccessKey = "On";
                lamp6.Fill = new SolidColorBrush(Colors.HotPink);
                lamp6.AccessKey = "On";
                lamp7.Fill = new SolidColorBrush(Colors.HotPink);
                lamp7.AccessKey = "On";
                lamp8.Fill = new SolidColorBrush(Colors.HotPink);
                lamp8.AccessKey = "On";
                lamp9.Fill = new SolidColorBrush(Colors.HotPink);
                lamp9.AccessKey = "On";
                lamp10.Fill = new SolidColorBrush(Colors.HotPink);
                lamp10.AccessKey = "On";
                buttonForAll.Background = new SolidColorBrush(Colors.Yellow);
                buttonForAll.AccessKey = "On";
                buttonForAll.Content = "Éteindre";
            }

            else
            {
                lamp1.AccessKey = "Off";
                lamp1.Fill = new SolidColorBrush(Colors.Gray);
                lamp2.AccessKey = "Off";
                lamp2.Fill = new SolidColorBrush(Colors.Gray);
                lamp3.AccessKey = "Off";
                lamp3.Fill = new SolidColorBrush(Colors.Gray);
                lamp4.AccessKey = "Off";
                lamp4.Fill = new SolidColorBrush(Colors.Gray);
                lamp5.AccessKey = "Off";
                lamp5.Fill = new SolidColorBrush(Colors.Gray);
                lamp6.AccessKey = "Off";
                lamp6.Fill = new SolidColorBrush(Colors.Gray);
                lamp7.AccessKey = "Off";
                lamp7.Fill = new SolidColorBrush(Colors.Gray);
                lamp8.AccessKey = "Off";
                lamp8.Fill = new SolidColorBrush(Colors.Gray);
                lamp9.AccessKey = "Off";
                lamp9.Fill = new SolidColorBrush(Colors.Gray);
                lamp10.Fill = new SolidColorBrush(Colors.Gray);
                lamp10.AccessKey = "Off";
                buttonForAll.Background = new SolidColorBrush(Colors.Gray);
                buttonForAll.AccessKey = "Off";
                buttonForAll.Content = "Allumer";
            }

        }
           


        

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (lamp1.AccessKey.Equals("Off"))
            {
                lamp1.Fill = new SolidColorBrush(Colors.HotPink);
                lamp1.AccessKey = "On";
            }
            else
            {
                lamp1.Fill = new SolidColorBrush(Colors.Gray);
                lamp1.AccessKey = "Off";
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (lamp2.AccessKey.Equals("Off"))
            {
                lamp2.Fill = new SolidColorBrush(Colors.HotPink);
                lamp2.AccessKey = "On";
            }
            else
            {
                lamp2.Fill = new SolidColorBrush(Colors.Gray);
                lamp2.AccessKey = "Off";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (lamp3.AccessKey.Equals("Off"))
            {
                lamp3.Fill = new SolidColorBrush(Colors.HotPink);
                lamp3.AccessKey = "On";
            }
            else
            {
                lamp3.Fill = new SolidColorBrush(Colors.Gray);
                lamp3.AccessKey = "Off";
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (lamp4.AccessKey.Equals("Off"))
            {
                lamp4.Fill = new SolidColorBrush(Colors.HotPink);
                lamp4.AccessKey = "On";
            }
            else
            {
                lamp4.Fill = new SolidColorBrush(Colors.Gray);
                lamp4.AccessKey = "Off";
            }
        }
         private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (lamp5.AccessKey.Equals("Off"))
            {
                lamp5.Fill = new SolidColorBrush(Colors.HotPink);
                lamp5.AccessKey = "On";
            }
            else
            {
                lamp5.Fill = new SolidColorBrush(Colors.Gray);
                lamp5.AccessKey = "Off";
            }
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (lamp6.AccessKey.Equals("Off"))
            {
                lamp6.Fill = new SolidColorBrush(Colors.HotPink);
                lamp6.AccessKey = "On";
            }
            else
            {
                lamp6.Fill = new SolidColorBrush(Colors.Gray);
                lamp6.AccessKey = "Off";
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (lamp7.AccessKey.Equals("Off"))
            {
                lamp7.Fill = new SolidColorBrush(Colors.HotPink);
                lamp7.AccessKey = "On";
            }
            else
            {
                lamp7.Fill = new SolidColorBrush(Colors.Gray);
                lamp7.AccessKey = "Off";
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (lamp8.AccessKey.Equals("Off"))
            {
                lamp8.Fill = new SolidColorBrush(Colors.HotPink);
                lamp8.AccessKey = "On";
            }
            else
            {
                lamp8.Fill = new SolidColorBrush(Colors.Gray);
                lamp8.AccessKey = "Off";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (lamp9.AccessKey.Equals("Off"))
            {
                lamp9.Fill = new SolidColorBrush(Colors.HotPink);
                lamp9.AccessKey = "On";
            }
            else
            {
                lamp9.Fill = new SolidColorBrush(Colors.Gray);
                lamp9.AccessKey = "Off";
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (lamp10.AccessKey.Equals("Off"))
            {
                lamp10.Fill = new SolidColorBrush(Colors.HotPink);
                lamp10.AccessKey = "On";
            }
            else
            {
                lamp10.Fill = new SolidColorBrush(Colors.Gray);
                lamp10.AccessKey = "Off";
            }
        }

        //DispatcherTimer dispatcherTimer;
        //DateTimeOffset startTime;
        //DateTimeOffset lastTime;
        //DateTimeOffset stopTime;
        //int timesTicked = 1;
        //int timesToTick = 10;

        //public void DispatcherTimerSetup()
        //{
        //    dispatcherTimer = new DispatcherTimer();
        //    dispatcherTimer.Tick += dispatcherTimer_Tick;
        //    dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        //    //IsEnabled defaults to false
        //    TimerLog.Text += "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
        //    startTime = DateTimeOffset.Now;
        //    lastTime = startTime;
        //    TimerLog.Text += "Calling dispatcherTimer.Start()\n";
        //    dispatcherTimer.Start();
        //    //IsEnabled should now be true after calling start
        //    TimerLog.Text += "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
        //}

        //void dispatcherTimer_Tick(object sender, object e)
        //{
        //    DateTimeOffset time = DateTimeOffset.Now;
        //    TimeSpan span = time - lastTime;
        //    lastTime = time;
        //    //Time since last tick should be very very close to Interval
        //    TimerLog.Text += timesTicked + "\t time since last tick: " + span.ToString() + "\n";
        //    timesTicked++;
        //    if (timesTicked > timesToTick)
        //    {
        //        stopTime = time;
        //        TimerLog.Text += "Calling dispatcherTimer.Stop()\n";
        //        dispatcherTimer.Stop();
        //        //IsEnabled should now be false after calling stop
        //        TimerLog.Text += "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
        //        span = stopTime - startTime;
        //        TimerLog.Text += "Total Time Start-Stop: " + span.ToString() + "\n";
        //    }
        //}
    }
}
