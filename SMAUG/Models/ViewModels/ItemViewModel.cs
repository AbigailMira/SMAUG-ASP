using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Models
{
    public class ItemViewModel
    {
        public int Ite_Id { get; set; }
        [DisplayName("Type")]
        public string Ite_Type { get; set; }
        [DisplayName("Name")]
        public string Ite_Name { get; set; }
        [DisplayName("Collection")]
        public string Ite_Collection { get; set; }
        [DisplayName("Edition")]
        public string Ite_Edition { get; set; }
        [DisplayName("Editor")]
        public string Ite_Editor { get; set; }
        [DisplayName("ISBN")]
        public string Ite_ISBN { get; set; }
        [DisplayName("Made In")]
        public Nullable<short> Ite_ProdDate { get; set; }
    }
}