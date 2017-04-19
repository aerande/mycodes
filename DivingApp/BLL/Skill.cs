using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Skill : IModel
    {
        public int SkillID
        { get; set; }

        public string Name
        { get; set; }

        public string Description
        { get; set; }

        public string Type
        { get; set; }

        public string PhotoPath
        { get; set; }
                
        public DateTime UploadTime
        { get; set; }

        public int AppUserID
        { get; set; }

        public Boolean IsActive
        { get; set; }

    }
}
