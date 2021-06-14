using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class CarSpeed
    {
        private string engineNumber;
        private float acceleration;
        private float time;

        public CarSpeed()
        {
            this.engineNumber = null;
            this.acceleration = 0;
            this.time = 0;
        }
        public string Engine
        {
            set {engineNumber = value; }
            get {return engineNumber; }

        }
        public float Acceleration
        {
            set { acceleration = value; }
            get { return acceleration; }
        }
        public float Time
        {
            set { time = value; }
            get { return time; }
        }

        public float get_Velocity()
        {
            return this.acceleration * this.time;  //calculating velocity
        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Details for Car " + i + ":");
                Console.Write("Input the engine number : ");
                string s = Console.ReadLine();
                Console.Write("Input the acceleartion : ");
                float f = float.Parse(Console.ReadLine());
                Console.Write("Enter the time : ");
                float t = float.Parse(Console.ReadLine());
                CarSpeed obj = new CarSpeed();
               
                obj.Engine = s;
                obj.Acceleration = f;
                obj.Time = t;

                Console.WriteLine("Engine number of a car set to " +obj.Engine);
                Console.WriteLine("Car's acceleration is " + obj.Acceleration);
                if (obj.get_Velocity() > 0)
                    Console.WriteLine("Car started Successfully");
                Console.WriteLine("Velocity of the car after " + obj.Time + " seconds is " + obj.get_Velocity());
                Console.WriteLine("Car stopped Successfully");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
