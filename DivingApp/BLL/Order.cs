using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Order : IModel
    {
        public int OrderID
        { get; set; }

        public int AccessoryID
        { get; set; }

        public DateTime OrderTime
        { get; set; }

        public float OrderAmount
        { get; set; }

        public int AppUserID
        { get; set; }

        public string Status
        { get; set; }

        public string PaymentMode
        { get; set; }

        public DateTime TentativeDate
        { get; set; }
    }
}
