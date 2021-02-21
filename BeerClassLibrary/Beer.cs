using System;

namespace BeerClassLibrary
{
    public class Beer
    {
        private int _id;
        private double _pris;
        private string _navn;
        private double _abv;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set
            {
                if (value.Length < 4) throw new ArgumentException("The Name cannot be shorter than 4 characters"); 
                _navn = value; 

            }
        }

        public double Pris
        {
            get { return _pris; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("The price cannot be 0 or less");
                _pris = value;
            }
        }

        public double Abv
        {
            get { return _abv; }
            set
            {
                if (value <= 0 || value >= 100)
                    throw new ArgumentOutOfRangeException("Abv cannot be 0 or less and/or 100 or more");
                _abv = value;
            }
        }

        public Beer(int id, string navn, double pris, double abv)
        {
            Id = id;
            Navn = navn;
            Pris = pris;
            Abv = abv;
        }
        
    }
}
