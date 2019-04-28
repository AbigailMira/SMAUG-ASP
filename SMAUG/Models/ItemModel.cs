using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Edmx
{
    public class ItemModel
    {
        public int Ite_Id { get; set; }
        [DisplayName("Type")]
        public string Ite_Type{ get; set; }
        [DisplayName("Name")]
        public string Ite_Name { get; set; }
        [DisplayName("Made in")]
        public int Ite_ProdDate { get; set; }
    }
}