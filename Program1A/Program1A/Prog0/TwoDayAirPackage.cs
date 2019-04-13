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

//Two day air package is derived from air package, it adds a delivery type

namespace Prog0
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver }; //Delivery enum specifies types

        //Pre: NA
        //Post: Constuctor includes length, width, height and weight for packages
        //and includes orgin address and destination address from base class
        //(parcel) adds delivery type and express fee
        public TwoDayAirPackage(Address orginAddress, Address destAddress,
           double length, double width, double height, double weight, decimal expressFee,
           Delivery delEnum)
           : base(orginAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = delEnum;
        }

        //Pre: NA
        //Post: Type returned, value is set
        public Delivery DeliveryType { get; set; }

        public override decimal CalcCost()
        {
            decimal twentyFive = .25M; //used to multiply in cost formula
                                       //unsure what the exact name is
            decimal saverCost = .90M; //multiplied to cost if saver Delivery type
            decimal result; //result of cost, returned later

            result = twentyFive * ((Decimal)Dims) + twentyFive * ((Decimal)Weight);

            if (DeliveryType == Delivery.Saver)
                result *= saverCost;

            return result;

        }


        //Pre: NA
        //Post: Data is returned 
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"Two day air package:{NL}{NL}{base.ToString()}{NL}Delivery Type: " +
                $"{DeliveryType}";

            return result;
            
        }
    }
}
