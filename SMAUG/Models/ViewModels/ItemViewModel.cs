using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Edmx
{
    public class ItemViewModel
    {
        public string Author { get; set; }
        [Display(Name = "Made by")]
        public string Maker { get; set; }
        [Display(Name="Name")]
        public string ItemName { get; set; }
        [Display(Name = "Made in")]
        public int MakingYear { get; set; }
        [Display(Name = "Type")]
        public string ItemType { get; set; }

        public string CanonPublication { get; set; }
        public string PublicationAdapter { get; set; }
        public string Adaptation { get; set; }

        public string CanonEntity { get; set; }
        public string EntityInterpreter { get; set; }
        public string Interpretation { get; set; }
    }
}