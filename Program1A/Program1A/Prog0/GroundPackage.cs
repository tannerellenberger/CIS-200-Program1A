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

//Ground package is derived from Package class, it includes Zone Distance

namespace Prog0
{
    public class GroundPackage : Package
    {
        //Pre: NA
        //Post: //Post: Constuctor includes length, width, height and weight for packages
        //and includes orgin address and destination address from base class
        //(parcel)
        public GroundPackage(Address orginAddress, Address destAddress, double length,
           double width, double height, double weight)
            : base(orginAddress, destAddress, length, width, height, weight)
        {

        }

        //Pre: NA
        //Post: Difference of zips is returned, first digit of each zip is the
        //value of variable distance
        public int ZoneDistance()
        {
            int distance; //Difference of Zips
            int distanceDifference = 10000; //Int used to divide Zips

            distance = (OriginAddress.Zip / distanceDifference) - (DestinationAddress.Zip / distanceDifference);

            return distance;
        }

        //Pre: NA
        //Post: cost is returned
        public override decimal CalcCost()
        {
            decimal cost; //cost of ground package
            decimal twenty = .20M; //constant decimal used in formula
            decimal five = .05M; //constant decimal used in formula

            cost = twenty * ((decimal)Length + (decimal)Width + (decimal)Height) +
                five * (ZoneDistance() + 1) * ((decimal)Weight);

            return cost;
        }

        //Pre: NA
        //Post: data is returned in string format
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result; //result of string

            result = $"Ground package:{NL}{NL}{base.ToString()}" +
                $"Zone Distance: {ZoneDistance()}";

            return result;
        }
    }
}
