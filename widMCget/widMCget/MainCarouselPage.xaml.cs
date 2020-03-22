using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace widMCget
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainCarouselPage : CarouselPage
    {
        SensorSpeed speed = SensorSpeed.UI;
        DateTime dateTimeNow;
        int totalCookies;
        int totalEggs;
        bool isFlashlight;

        public MainCarouselPage()
        {
            InitializeComponent();

            dateTimeNow = DateTime.Now;
            totalCookies = 0;
            totalEggs = 1000000;
            isFlashlight = false;
            Compass.ReadingChanged += Compass_ReadingChanged;
            ToggleCompass();
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

        private async void OnTorchTapped(object sender, EventArgs e)
        {
            if (!isFlashlight)
            {
                TorchImage.Source = "torch_on";
                isFlashlight = true;
                try
                {
                    await Flashlight.TurnOnAsync();
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to enable flashlight");
                }
            }
            else
            {
                TorchImage.Source = "torch_off";
                isFlashlight = false;
                try
                {
                    await Flashlight.TurnOffAsync();
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to disable flashlight");
                }
            }
        }

        private void OnBedTapped(object sender, EventArgs e)
        {
            if (dateTimeNow.Hour >= 21 || (dateTimeNow.Hour >= 0 && dateTimeNow.Hour <= 6))
            {
                Console.WriteLine("You can sleep");
                BedPage.BackgroundColor = Color.FromHex("#63232d");
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

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            Console.WriteLine($"Reading: {data.HeadingMagneticNorth} degrees");
            SetCompass(data.HeadingMagneticNorth);
        }

        public void ToggleCompass()
        {
            try
            {
                if (Compass.IsMonitoring)
                    Compass.Stop();
                else
                    Compass.Start(speed);
            }
            catch (Exception)
            {
                Console.WriteLine("Error with compass");
            }
        }

        void SetCompass(double data)
        {
            if (data >= 352.5 || data <= 7.5)
                CompassImage.Source = "compass_16";
            else if (data >= 7.5 && data <= 22.5)
                CompassImage.Source = "compass_15";
            else if (data >= 22.5 && data <= 37.5)
                CompassImage.Source = "compass_14";
            else if (data >= 37.5 && data <= 52.5)
                CompassImage.Source = "compass_13";
            else if (data >= 52.5 && data <= 67.5)
                CompassImage.Source = "compass_12";
            else if (data >= 67.5 && data <= 82.5)
                CompassImage.Source = "compass_10";
            else if (data >= 82.5 && data <= 97.5)
                CompassImage.Source = "compass_08";
            else if (data >= 97.5 && data <= 112.5)
                CompassImage.Source = "compass_06";
            else if (data >= 112.5 && data <= 127.5)
                CompassImage.Source = "compass_04";
            else if (data >= 127.5 && data <= 142.5)
                CompassImage.Source = "compass_03";
            else if (data >= 142.5 && data <= 157.5)
                CompassImage.Source = "compass_02";
            else if (data >= 157.5 && data <= 172.5)
                CompassImage.Source = "compass_01";
            else if (data >= 172.5 && data <= 187.5)
                CompassImage.Source = "compass_00";
            else if (data >= 187.5 && data <= 202.5)
                CompassImage.Source = "compass_31";
            else if (data >= 202.5 && data <= 217.5)
                CompassImage.Source = "compass_30";
            else if (data >= 217.5 && data <= 232.5)
                CompassImage.Source = "compass_29";
            else if (data >= 232.5 && data <= 247.5)
                CompassImage.Source = "compass_28";
            else if (data >= 247.5 && data <= 262.5)
                CompassImage.Source = "compass_26";
            else if (data >= 262.5 && data <= 277.5)
                CompassImage.Source = "compass_23";
            else if (data >= 277.5 && data <= 292.5)
                CompassImage.Source = "compass_22";
            else if (data >= 292.5 && data <= 307.5)
                CompassImage.Source = "compass_20";
            else if (data >= 307.5 && data <= 322.5)
                CompassImage.Source = "compass_19";
            else if (data >= 322.5 && data <= 337.5)
                CompassImage.Source = "compass_18";
            else if (data >= 337.5 || data <= 352.5)
                CompassImage.Source = "compass_17";
        }
    }
}