using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
        public class Teacher
        {

        private string id;
        private string name; 
        private string lastname; 
        private int hours;
        private int payperonehour;

        public string Id 

        { 
        get { return id; }
        set {id = value; }

        }

        public string Name

        {
        get { return name;}

        set {name =value;}
        }


        public String LastName

        { 
        get { return lastname; }

        set {lastname = value; }

        }

        public int Hours

        {

        get { return hours; }

        set { hours = value; }

        }

        public int PayPerOneHour
        {

            get { return payperonehour; }

            set
            {
                if (value > 0)
                {
                    payperonehour = value;
                }

            }
        }

        public Teacher (){}
        public Teacher (string Id, string Name, string Lastname, int Hours, int PayperOneHour) 
        { 
        id = Id;
        name =Name;
        lastname = LastName;
        hours = Hours;
        payperonehour = PayPerOneHour;

        }

        public long Payment ()

        {

        return hours * PayPerOneHour;

        }

}//end class



class Program
{
    static void Main(string[] args)
    {
        Teacher th = new Teacher("123", "Ali", "Ahmadi", 16, 40000);
        long Pay = th.Payment();
        Console.WriteLine(Pay);
    }
}
    

    }



