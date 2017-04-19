using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Accessory : IModel
    {
        public int AccessoryID
        { get; set; }

        public string Name
        { get; set; }

        public string PhotoPath
        { get; set; }

        public string Description
        { get; set; }

        public int Cost
        { get; set; }

        public int MRP
        { get; set; }

        public int Discount
        { get; set; }

        public string Category
        { get; set; }
    }
}
