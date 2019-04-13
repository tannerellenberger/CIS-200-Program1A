//D3894
// Program1A
// CIS 200-01
// Fall 2018
// Due: 9/24/2018


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Package class is derived from parcel class, it includes length, width
//height and weight

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double _length;   //Package length inches
        private double _width;    //Package width inches
        private double _height;   //Package height inches
        private double _weight;   //Package weight pounds

        //Pre: NA
        //Post: Constuctor creates length, width, height and weight for packages
        //and includes orgin address and destination address from base class
        //(parcel)
        public Package(Address orginAddress, Address destAddress, double length,
            double width, double height, double weight)
            : base(orginAddress, destAddress)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;

        }


        public double Length
        {
            //Pre: NA
            //Post: get return's package length
            get
            {
                return _length;
            }
            
            //Pre: NA
            //Post: sets value to length
            set
            {
                _length = value;
            }
        }

        public double Width
        {
            //Pre: NA
            //Post: get return's package width
            get
            {
                return _width;
            }

            //Pre: NA
            //Post: sets value to width
            set
            {
                _width = value;
            }
        }

        public double Height
        {
            //Pre: NA
            //Post: get returns package height
            get
            {
                return _height;
            }

            //Pre: NA
            //Post: sets value to height
            set
            {
                _height = value;
            }
        }

        public double Weight
        {
            //Pre: NA
            //Post: get returns package weight
            get
            {
                return _weight;
            }

            //Pre: NA
            //Post: sets value to weight
            set
            {
                _weight = value;
            }
        }

        //Pre: NA
        //Post: String return's all package data
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"{base.ToString()}{NL}length: {Length}{NL}width: {Width}{NL}" +
             $"height: {Height}{NL}weight: {Weight} lbs{NL}";
            

            return result;

        }

        //Pre: NA
        //Post: Used to return package total dims needed in later classes
        protected double Dims
        {


            get
            {
                return (Length + Height + Width);
            }

        }
    }
}
