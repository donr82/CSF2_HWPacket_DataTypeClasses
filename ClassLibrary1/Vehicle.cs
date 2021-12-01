using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehicle
    {
        /*
         * 2. Vehicle
         *  a. make - string
         *  b. model - string
         *  c. year - int
         *  d. weight - float
         *  
         *  Include all fields, properties, two constructors (default and fully  qualified),
         *  and a ToString() for each class. Then test the class you created in the TesterProgram
         *  project by creating objects using both constructors and writing them on the screen.
         *  
         *  Merge each completed branch back to the master branch and push master to the remote repo
         */

        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public Vehicle() { }

        public override string ToString()
        {
            return string.Format($"Make: {Make}/n" +
                                 $"Model: {Model}\n" +
                                 $"Year: {Year}\n" +
                                 $"Weight: {Weight:n0}\n");
        }

    }
}
