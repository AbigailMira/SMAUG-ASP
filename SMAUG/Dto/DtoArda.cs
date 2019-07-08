using SMAUG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoArda
    {
        public int Ard_Id { get; set; }
        public string Ard_Name { get; set; }
        public string Ard_Type { get; set; }
        public string Ard_Race { get; set; }
        public string Ard_People { get; set; }
        public Nullable<int> Ard_FirstAppearance { get; set; }
        public string Ard_Gender { get; set; }

        public virtual ICollection<DtoPublication> Develops { get; set; }
        public virtual ICollection<DtoPerson> Interpretor { get; set; }
        public virtual ICollection<DtoItem> RefersTo { get; set; }
        public virtual ICollection<DtoPerson> Inventor { get; set; }
        public virtual ICollection<DtoPublication> Introduces { get; set; }

        public DtoArda()
        {
        }
    }
}