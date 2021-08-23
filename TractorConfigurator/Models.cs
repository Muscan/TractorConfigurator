using System;
using System.Collections.Generic;
using System.Text;

namespace TractorConfigurator
{
    class Models
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int HorsePower { get; set; }

        public string FinalPrintMessageFormat
        {
            get
            {
                return string.Format($"Model Name: {Name} - Price: {Price} - Horse Power: {HorsePower}");
            }
        }

    }
}
