using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class FAQ : IModel
    {
        public int FAQID
        { get; set; }

        public string Title
        { get; set; }

        public DateTime Date
        { get; set; }
               
    }
}
