using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Encapsulation_Pratik
{
    internal class Car
    {
        public void CarInfo()
        {
            Console.WriteLine("Arabanızın bilgileri: ");
            Console.WriteLine("Marka: " + BrandName);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Renk: " + Color);
            Console.WriteLine("Kapı sayısı: " + DoorNumber);
        }

        public string BrandName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        private int _doorNumber;
        public int DoorNumber
        {
            get
            {
                return _doorNumber;
            }

            set
            {
                if (value != 2 && value != 4)
                {
                    Console.WriteLine("Geçersiz bir kapı sayısı girdiniz. Kapı sayısı 2 veya 4 olabilir.");
                    _doorNumber = 0;
                }
                else
                {
                    _doorNumber = value;
                }
            }
        }

    }
}
