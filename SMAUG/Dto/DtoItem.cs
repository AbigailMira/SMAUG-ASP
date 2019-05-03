using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoItem

    {
        public List<DtoItem> Ite_Id { get; set; }
        [DisplayName("Type")]
        public List<DtoItem> Ite_Type { get; set; }
        [DisplayName("Name")]
        public List<DtoItem> Ite_Name { get; set; }
        [DisplayName("Collection")]
        public List<DtoItem> Ite_Collection { get; set; }
        [DisplayName("Edition")]
        public List<DtoItem> Ite_Edition { get; set; }
        [DisplayName("Editor")]
        public List<DtoItem> Ite_Editor { get; set; }
        [DisplayName("ISBN")]
        public List<DtoItem> Ite_ISBN { get; set; }
        [DisplayName("Made In")]
        public List<DtoItem> Ite_ProdDate { get; set; }
    }
}