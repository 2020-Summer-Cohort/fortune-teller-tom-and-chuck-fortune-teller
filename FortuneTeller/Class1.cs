using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Xml.Schema;

namespace FortuneTeller
{
    public class FortuneTeller
    {
        public string Help { get; set; }
        public string ColorRed { get; set; }


        public FortuneTeller()
        {
            Help = "red, orange, yellow, green, blue, indigo, violet";
            ColorRed = "fortune";

        }
        
        public string GetHelp()
        {
            return Help;
        }

        public string GetColorRed()
        {
            
            return ColorRed;

        }


            
    }
    
}
