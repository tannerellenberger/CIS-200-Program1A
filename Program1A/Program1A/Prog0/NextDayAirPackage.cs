using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Next day air is derived from air package and adds an express fee

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; //express fee private field

        //Pre: NA
        //Post: Constuctor includes length, width, height and weight for packages
        //and includes orgin address and destination address from base class
        //(parcel), adds express fee
        public NextDayAirPackage(Address orginAddress, Address destAddress,
            double length, double width, double height, double weight, decimal expressFee)
            : base(orginAddress, destAddress, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            //Pre: NA
            //Post: get returns express fee
            get
            {
                return _expressFee;
            }

            //Pre: NA
            //Post: sets value to express fee
            private set
            {
                _expressFee = value;
            }
        }

        //Pre: NA
        //Post: Package cost is returned, determined by weight and total dims
        public override decimal CalcCost()
        {

            decimal forty = .40M; //decimal .40 used in formula
            decimal thirty = .30M; //decimal .30 used in formula
            decimal weightCharge = .25M; //weight charge in formula
            decimal sizeCharge = .25M; //size charge in formula
            decimal result; //result of cost

            result = forty * ((decimal)Dims) + thirty * ((decimal)Weight) +
                ExpressFee;

            if (IsHeavy())
                result = weightCharge * ((decimal)Weight);
            if (IsLarge())
                result = sizeCharge * ((decimal)Dims);

            return result;
            
        }


        //Pre: NA
        //Post: Next day air string of data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"{NL}{base.ToString()}{NL}Express Fee: {ExpressFee:C}";

            return result;

        }
    }
}

    

