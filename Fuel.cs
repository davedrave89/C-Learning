using System;

namespace FuelClass
{
    public class Fuel
    {
        private float _distance_travelled; //these are private fields, so should be in camelCase, eg. distanceTravelled
        private float _cost;
        private float _litres_used;

        public Fuel(float distance, float cost, float litres_used)//parameters are styled like fields, litresUsed
        {
            _distance_travelled = distance; 
            _cost = cost;
            _litres_used = litres_used;
        }

        public Fuel()
        {
            _distance_travelled = 0;
            _cost = 0;
            _litres_used = 0;
        }

        public float DistanceTravelled
        {
            set => _distance_travelled = value;
            get
            {
                return _distance_travelled;
            }
        }
        public float Cost
        {
            set => _cost = value;
            get
            {
                return _cost;
            }
        }
        public float LitresUsed
        {
            set => _litres_used = value;
            get
            {
                return _litres_used;
            }
        }

        public float KilometersPerLitre()
        {
            return (_litres_used * 100) / _distance_travelled;
        }

        public float CostForDistanceTravelled()
        {
            return _litres_used * _cost;
        }

        public string CheckUserInput(string value)
        {
            /* Dave Question: Is this the best way to implement a Try catch? */
            /*Dave Answer, the below isnt really a try catch, 
            a tryParse is just part of the prebuilt libraries (theres tonnes unlike java but probably python is good)
            
            TryParse could be considered a way of avoiding causing an exception to catch. it tries to parse and if it fails it just returns a 0
            
            notice that it returns a bool which is true if parse is successful, but also uses "out" to return the parsed value back as an int
            
            "out" should be used sparingly in your own code, but is perfect to use in a tryparse.
            
            a try catch would be :
            try
            {
                //code here
            }
            catch(Exception exceptionObjectThatisReturned)
            {
                //do something with exception Object here
            }
            
            I think what you did is fine for the most part. Try Catches should maybe be avoided as a tool to control 
            the flow of a program which is what you would have been doing with it.
            
            The while itself i wouldnt be mad on, whiles have a danger of running indefinately. I would use a for with a limit of attempts, 
            or else while using a counter variable
            */
            int line;
            while (!int.TryParse(value, out line))
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                value = Console.ReadLine();
            }
            return value;
        }
    }
}
