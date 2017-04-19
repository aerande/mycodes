using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Medicine : IModel
    {
        public int MedicineID
        { get; set; }

        public string Name
        { get; set; }

        public string Description
        { get; set; }

        public float Cost
        { get; set; }

        public string Purpose
        { get; set; }

    }
}
