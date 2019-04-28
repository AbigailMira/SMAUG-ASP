using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoItem
    {
        public string Maker { get; set; }
        public string ItemName { get; set; }
        public int MakingYear { get; set; }
        public string ItemType { get; set; }

        public string CanonPublication { get; set; }
        public string PublicationAdapter { get; set; }
        public string Adaptation { get; set; }

        public string CanonEntity { get; set; }
        public string EntityInterpreter { get; set; }
        public string Interpretation { get; set; }

    }
}