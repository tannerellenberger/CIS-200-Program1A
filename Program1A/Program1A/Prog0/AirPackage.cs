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

//Air Package class is derived from package class, determines if package is
//heavy or if it is large

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        //Post: Constuctor includes length, width, height and weight for packages
        //and includes orgin address and destination address from base class
        //(parcel)
        public AirPackage(Address orginAddress, Address destAddress,
            double length, double width, double height, double weight)
            : base(orginAddress, destAddress, length, width, height, weight)
        {

        }

        private double heavy = 75; //used to hold value for heavy constant
        private double large = 100; //used to hold value for large constant
        
        //Pre: NA
        //Post: returns boolean true if package weight is over/equal to 75 lbs
        public bool IsHeavy()
        {

            return (Weight >= heavy); //if weight is greater or equal 
                                     //to 75 returns boolean
        }

        //Pre: NA
        //Post: returns boolean true if package dims is over/equal to 100
        public bool IsLarge()
        {
            return (Dims >= large); //if total dims is greater or equal to 100
                                    //returns a boolean
        }

        //Pre: NA
        //Post: String return's all package data
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result; //holds final result

            result = $"Air Package:{NL}{NL}{base.ToString()} {NL}Over 75 pounds? " +
                $"{IsHeavy()}{NL}Larger than 100 inches? {IsLarge()}";

            return result;
        }
    }

}
