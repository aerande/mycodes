using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Deal : IModel
    {
        public int DealID
        { get; set; }

        public string Title
        { get; set; }

        public string Description
        { get; set; }

        public string PhotoPath
        { get; set; }

    }
}
