﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace widMCget
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainCarouselPage : CarouselPage
    {
        DateTime dateTimeNow;
        int totalCookies;
        int totalEggs;

        public MainCarouselPage()
        {
            InitializeComponent();

            dateTimeNow = DateTime.Now;
            totalCookies = 0;
            totalEggs = 1000000;

            SetClock();

        }

        public void SetClock()
        {

            if (dateTimeNow.Hour == 12)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_00";
                else
                    ClockImage.Source = "clock_02";
            }
            else if (dateTimeNow.Hour == 13)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_04";
                else
                    ClockImage.Source = "clock_05";
            }
            else if (dateTimeNow.Hour == 14)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_06";
                else
                    ClockImage.Source = "clock_07";
            }
            else if (dateTimeNow.Hour == 15)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_08";
                else
                    ClockImage.Source = "clock_10";
            }
            else if (dateTimeNow.Hour == 16)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_11";
                else
                    ClockImage.Source = "clock_12";
            }
            else if (dateTimeNow.Hour == 17)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_13";
                else
                    ClockImage.Source = "clock_14";
            }
            else if (dateTimeNow.Hour == 18)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_15";
                else
                    ClockImage.Source = "clock_16";
            }
            else if (dateTimeNow.Hour == 19)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_17";
                else
                    ClockImage.Source = "clock_18";
            }
            else if (dateTimeNow.Hour == 20)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_20";
                else
                    ClockImage.Source = "clock_21";
            }
            else if (dateTimeNow.Hour == 21)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_22";
                else
                    ClockImage.Source = "clock_24";
            }
            else if (dateTimeNow.Hour == 22)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_25";
                else
                    ClockImage.Source = "clock_26";
            }
            else if (dateTimeNow.Hour == 23)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_28";
                else
                    ClockImage.Source = "clock_30";
            }
            else if (dateTimeNow.Hour == 0)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_31";
                else
                    ClockImage.Source = "clock_34";
            }
            else if (dateTimeNow.Hour == 1)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_35";
                else
                    ClockImage.Source = "clock_37";
            }
            else if (dateTimeNow.Hour == 2)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_38";
                else
                    ClockImage.Source = "clock_40";
            }
            else if (dateTimeNow.Hour == 3)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_42";
                else
                    ClockImage.Source = "clock_44";
            }
            else if (dateTimeNow.Hour == 4)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_45";
                else
                    ClockImage.Source = "clock_46";
            }
            else if (dateTimeNow.Hour == 5)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_47";
                else
                    ClockImage.Source = "clock_48";
            }
            else if (dateTimeNow.Hour == 6)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_49";
                else
                    ClockImage.Source = "clock_50";
            }
            else if (dateTimeNow.Hour == 7)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_51";
                else
                    ClockImage.Source = "clock_53";
            }
            else if (dateTimeNow.Hour == 8)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_54";
                else
                    ClockImage.Source = "clock_56";
            }
            else if (dateTimeNow.Hour == 9)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_57";
                else
                    ClockImage.Source = "clock_58";
            }
            else if (dateTimeNow.Hour == 10)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_59";
                else
                    ClockImage.Source = "clock_60";
            }
            else if (dateTimeNow.Hour == 11)
            {
                if (dateTimeNow.Minute >= 0 && dateTimeNow.Minute < 30)
                    ClockImage.Source = "clock_62";
                else
                    ClockImage.Source = "clock_63";
            }
        }

        private void OnBedTapped(object sender, EventArgs e)
        {
            if (dateTimeNow.Hour >= 21 || (dateTimeNow.Hour >= 0 && dateTimeNow.Hour <= 6))
            {
                Console.WriteLine("You can sleep");
            }
            else
            {
                Console.WriteLine("You cant sleep");
            }
        }

        private void OnCookieTapped(object sender, EventArgs e)
        {
            totalCookies += 1;
            CookieLabel.Text = totalCookies.ToString();
        }

        private void OnEggTapped(object sender, EventArgs e)
        {
            totalEggs -= 1;
            EggLabel.Text = totalEggs.ToString();
        }
    }
}