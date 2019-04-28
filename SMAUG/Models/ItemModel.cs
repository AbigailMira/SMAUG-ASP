using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Models
{
    public class ItemModel
    {
        public int Ite_Id { get; set; }
        [Display(Name = "Type")]
        public string Ite_Type{ get; set; }
        [Display(Name = "Name")]
        public string Ite_Name { get; set; }
        [Display(Name = "Made in")]
        public int Ite_ProdDate { get; set; }
    }
}