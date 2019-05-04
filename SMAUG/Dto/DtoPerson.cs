using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoPerson
    {
        public int Per_Id { get; set; }
        public string Per_LastName { get; set; }
        public string Per_FirstName { get; set; }
        public Nullable<short> Per_Birth { get; set; }
        public Nullable<short> Per_Death { get; set; }
        public string Per_Job { get; set; }
        public string Per_Company { get; set; }

        public string FullName { get { return string.Concat(Per_FirstName + " " + Per_LastName); } }

        public DtoPerson()
        {
        }
    }
}