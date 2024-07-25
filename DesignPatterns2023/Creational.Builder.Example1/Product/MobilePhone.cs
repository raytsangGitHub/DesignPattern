using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example1
{
    // This is the "Product" class
    public class MobilePhone
    {
        // fields to hold the part type
        string phoneName;
        ScreenType phoneScreen;
        Battery phoneBattery;
        OperatingSystem phoneOS;
        Stylus phoneStylus;

       
        public MobilePhone(string name)   //ctor
        {
            phoneName = name;
        }

        // Public properties to access phone parts

        public string PhoneName { get; }
        //{
        //    get { return phoneName; }
        //}

        public ScreenType PhoneScreen
        {
            get { return phoneScreen; }
            set { phoneScreen = value; }
        }

        public Battery PhoneBattery
        {
            get { return phoneBattery; }
            set { phoneBattery = value; }
        }

        public OperatingSystem PhoneOS
        {
            get { return phoneOS; }
            set { phoneOS = value; }
        }

        public Stylus PhoneStylus
        {
            get { return phoneStylus; }
            set { phoneStylus = value; }
        }

        // Methiod to display phone details.  But not necessary same order as in the Director
        public override string ToString()
        {
            return string.Format($"Name: {PhoneName}\nScreen: {PhoneScreen}\nBattery {PhoneBattery}\nOS: {PhoneOS}\nStylus: {PhoneStylus}");
        }
    }
}
