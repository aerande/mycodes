using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class Resume: IModel
    {
        public int ResumeID
        { get; set; }

        public string Name
        { get; set; }

        public string Experience
        { get; set; }

        public string Qualification
        { get; set; }

        public string CertificateCourses
        { get; set; }

        public string LatestDivingSpot
        { get; set; }

        public string DivingSpotsVisited
        { get; set; }

    
    }
}
