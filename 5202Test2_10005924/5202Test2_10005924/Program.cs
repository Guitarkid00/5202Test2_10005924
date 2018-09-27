using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Test2_10005924
{
    // Layton Vincent-Stewart
    // Program that displays the information about a bird that the user inputs
    class Birds
    {
        private string name;
        private string species;
        private string sex;
        private int weight;
        private string band;

        public string Name { get { return name; } set { name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public string Band { get { return band; } set { band = value; } }

        public Birds(string _name,string _species,string _sex,int _weight,string _band) //Constructor
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = Convert.ToInt32(_weight);
            Band = _band;
        }

        public string displayBird() //Method to display bird information
        {
            return ($"{Name} {Species} {Sex} {Weight}grams {Band}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Birds b1 = new Birds("Name unknown", "Species unknown", "Sex unknown", 0, "Band Number unknown"); //Setting default values for constructor
            Console.WriteLine("Bird object created and default data loaded");
            Console.WriteLine();
            Console.WriteLine("PLEASE UPDATE BIRD DATA");
            Console.WriteLine();
            Console.Write("Enter bird name : ");
            b1.Name = Console.ReadLine(); // b1._____ rewriting the information for that part of the b1 object
            Console.Write("Enter bird species : ");
            b1.Species = Console.ReadLine();
            Console.Write("Enter sex of bird : ");
            b1.Sex = Console.ReadLine();
            Console.Write("Enter weight of bird (grams) : ");
            b1.Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter band number of bird : ");
            b1.Band = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("BIRD OF PREY DATA OUTPUT");
            Console.WriteLine(b1.displayBird());
            Console.WriteLine("******************************");
            Console.ReadLine();
        }
    }
}
