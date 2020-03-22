using System;
using Xamarin.Essentials;

namespace widMCget
{
    class CompassTest
    {
        SensorSpeed speed = SensorSpeed.UI;
        public CompassTest()
        {
            Compass.ReadingChanged += Compass_ReadingChanged;
        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            var data = e.Reading;
            Console.WriteLine($"Reading: {data.HeadingMagneticNorth} degrees");
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
    }
}
