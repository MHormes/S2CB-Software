using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1InheritanceTransportation
{
    public class Car : Transportation
    {
        private string licencePlate;
        private string color;

        public Car(string licencePlate, string color, int speed): base(speed) 
        {
            this.licencePlate = licencePlate;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Car: lp: {licencePlate}, color: {color}, speed: {base.ToString()}";
        }

        public override string MakeSound()
        {
            return "Honk!";
        }
    }
}
