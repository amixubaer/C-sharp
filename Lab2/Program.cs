using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Date
    {
        private int dd = 01, mm = 01, yy = 2017;

        public Date(int dd = 01, int mm = 01, int yy = 2017)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public void setDate(int dd, int mm, int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public int getDD
        {
            get { return dd; }
        }
        public int getMM
        {
            get { return mm; }
        }
        public int getYY
        {
            get { return yy; }
        }

    }
    class Appointment
    {
        private string NRIC = null;
        private string name = null;
        private double fees = 0.0;
        private Date visit;
        private Date nextvisit;

        public Appointment(string NRIC, string name, double fees, Date visit = null, Date nextvisit = null)
        {
            this.NRIC = null;
            this.name = null;
            this.fees = 0.0;
            this.visit = visit;
            this.nextvisit = nextvisit;
        }

        public void setAppt(string NRIC, string name, double fees, Date visit, Date nextvisit)
        {
            this.NRIC = NRIC;
            this.name = name;
            this.fees = fees;
            this.visit = visit;
            this.nextvisit = nextvisit;
        }
        public string getVisit
        {
            get => visit.getDD + "/" + visit.getMM + "/" + visit.getYY;
        }
        public string getnextVisit
        {
            get => nextvisit.getDD + "/" + nextvisit.getMM + "/" + nextvisit.getYY;
        }
        public string getName
        {
            get { return name; }
        }

        public void displayAppt()
        {
            Console.WriteLine("Patient ID: " + NRIC + ", " + getName + ", " + String.Format("{0:c}", fees));

            if (visit.getDD == 0 || visit.getMM == 0 || visit.getYY == 0)
            {
                Console.WriteLine("Date of Visit: " + "–");
            }
            else
            {
                Console.WriteLine("Date of Visit: " + getVisit);
            }

            if (nextvisit.getDD == 0 || nextvisit.getMM == 0 || nextvisit.getYY == 0)
            {
                Console.WriteLine("Date Next Visit: " + "–");
            }
            else
                Console.WriteLine("Date Next Visit: " + getnextVisit);

            Console.WriteLine("\n");

        }

        public void displayAppt(string NRIC)
        {
            if (Equals(NRIC, NRIC))
            {
                Console.WriteLine("Print single appointment:" + NRIC);
                Console.WriteLine("\nPatient ID: " + NRIC + ", " + getName + ", " + String.Format("{0:c}", fees));

              if (visit.getDD == 0 || visit.getMM == 0 || visit.getYY == 0)
                {
                    Console.WriteLine("Date of Visit: " + "–");
                }
                else
                {
                    Console.WriteLine("Date of Visit: " + getVisit);
                }

                if (nextvisit.getDD == 0 || nextvisit.getMM == 0 || nextvisit.getYY == 0)
                {
                    Console.WriteLine("Date Next Visit: " + "–");
                }
                else
                    Console.WriteLine("Date Next Visit: " + getnextVisit);

                Console.WriteLine("\n"); 
            }
           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(02, 02, 2015);
            Date n = new Date(02, 02, 2015);
            d.setDate(02, 03, 2015);
            n.setDate(08, 06, 2015);

            Appointment a = new Appointment("S12345", "Tan Ah Sam", 45.00, d, n);
            a.setAppt("S12345", "Tan Ah Sam", 45.00, d, n);
            a.displayAppt();

            Date d1 = new Date(03, 03, 2015);
            Date n1 = new Date(0, 0);
            d1.setDate(03, 03, 2015);
            n1.setDate(0, 0, 0);

            Appointment a1 = new Appointment("S34567", "Lee Tao San", 60.00, d1, n1);
            a1.setAppt("S34567", "Lee Tao San", 60.00, d1, n1);
            a1.displayAppt();

            Date d2 = new Date(10, 03, 2015);
            Date n2 = new Date(31, 03, 2015);
            d2.setDate(10, 03, 2015);
            n2.setDate(31, 03, 2015);

            Appointment a2 = new Appointment("S56783", "Sam Ting", 120.50, d2, n2);
            a2.setAppt("S56783", "Sam Ting", 120.50, d2, n2);
            a2.displayAppt();

            Date d3 = new Date(31, 03, 2015);
            Date n3 = new Date(30, 04, 2015);
            d3.setDate(31, 03, 2015);
            n3.setDate(30, 04, 2015);

            Appointment a3 = new Appointment("S98761", "Anthony Chin", 78.50, d3, n3);
            a3.setAppt("S98761", "Anthony Chin", 78.50, d3, n3);
            a3.displayAppt();

            a2.displayAppt("S56783");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }

    }
}