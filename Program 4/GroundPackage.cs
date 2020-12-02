using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {
        private int _originZip; //origin zip
        private int _destinationZip; //destination zip
        private double _length, _width, _height, _weight; //length, width, height, and weight
        private int _zoneDistance; //distance between origin and destination zip
        public const int zipLowThresh = 00000; //low threshold for zips
        public const int zipHighThresh = 99999; //high threshold for zips
        public const int dimensionLow = 0; //minimum for dimensions
        public const double dimensionDefault = 1.0; //default value for dimensions if value is invalid
        public const double SIZE_COST_FACTOR = .25; //size cost factor value
        public const double WEIGHT_COST_FACTOR = .45; //weight cost factor value
        public const int originDefault = 40202; //origin default if value is invalid
        public const int destDefault = 90210; //destination default if value is invalid


        public int OriginZip
        {
            //precondition: none
            //postcondition: pacakges origin zip is returned
            get
            {
                return _originZip;
            }
            //precondition: value >= 00000 && value <= 99999
            //postcondition: packages origin zip is set to a value or the default if value is invalid
            set
            {
                if (value > zipLowThresh && value <= zipHighThresh)
                    _originZip = value;
                else
                    _originZip = originDefault; //when invalid, value = 40202
            }
        }

        public int DestinationZip
        {
            //precondition: none
            //postcondition: pacakges destination zip is returned
            get
            {
                return _destinationZip;
            }
            //precondition: value >= 00000 && value <= 99999
            //postcondition: packages destination zip is set to a value or the default if value is invalid
            set
            {
                if (value > zipLowThresh && value <= zipHighThresh)
                    _destinationZip = value;
                else
                    _destinationZip = destDefault; //when invalid, value is 90210
            }
        }
        public double Length
        {
            //precondition: none
            //postcondition: returns packages length
            get
            {
                return _length;
            }
            //precondition: value > 0
            //postcondtion: packages length is set to value or default if value is invalid
            set
            {
                if (value > dimensionLow)
                    _length = value;
                else
                    _length = dimensionDefault; //when invalid, value is 1.0
            }
        }
        public double Width
        {
            //precondition: none
            //postcondition: returns packages width
            get
            {
                return _width;
            }
            //precondition: value > 0
            //postcondtion: packages width is set to value or default if value is invalid
            set
            {
                if (value > dimensionLow)
                    _width = value;
                else
                    _width = dimensionDefault; //when invalid, value is 1.0
            }
        }
        public double Height
        {
            //precondition: none
            //postcondition: returns packages height
            get
            {
                return _height;
            }
            //precondition: value > 0
            //postcondtion: packages is set to value or default if value is invalid
            set
            {
                if (value > dimensionLow)
                    _height = value;
                else
                    _height = dimensionDefault; //when invalid, value is 1.0
            }
        }
       public double Weight
        {
            //precondition: none
            //postcondition: returns packages weight
            get
            {
                return _weight;
            }
            //precondition: value > 0
            //postcondtion: packages weight is set to value or default if value is invalid
            set
            {
                if (value > dimensionLow)
                    _weight = value;
                else
                    _weight = dimensionDefault; //when invalid, value is 1.0
            }
        }
        public int ZoneDistance
        {
            //precondition: none
            //postcondition: returns distance between zipcodes (read only)
            get
            {
                _zoneDistance = Math.Abs((OriginZip / 10000) - (DestinationZip / 10000));
                

                return _zoneDistance;
            }
        }
        //precondition: none
        //postcondition: returns the calculated cost of shipping the package
        public double CalcCost()
        {
            return SIZE_COST_FACTOR * (Length + Width + Height) + WEIGHT_COST_FACTOR * (ZoneDistance + 1) * (Weight);
        }
        //precondition: none
        //postcondition: packages information is returned as a string
        public override string ToString()
        {
            return $"Orgin Zipcode is {OriginZip}, destination zipcode is {DestinationZip}, zone distance is {ZoneDistance} {Environment.NewLine}" +
                $"Package length is {Length}, width is {Width}, height is {Height}, weight is {Weight} {Environment.NewLine}" + $"Cost of shipping is {CalcCost():C}";
                
        }
        //precondition: none
        //postcondition: GroundPackage is created with all the needed values (constructor)
        public GroundPackage(int oz = 00000, int dz = 00000, double l = 1.0, double w = 1.0, double h = 1.0, double wt = 1.0)
        {
            OriginZip = oz; //set using origin zip property
            DestinationZip = dz; //set using destination zip property
            Length = l; //set using the length property
            Width = w; //set using the width property
            Height = h; //set using the height property
            Weight = wt; //set using the weight property

        }
        

         
    }
}
