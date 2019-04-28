using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Edmx
{
    public class ArdaModel
    {
        public int Ard_Id { get; set; }
        [Display(Name = "Name")]
        public string Ard_Name { get; set; }
    }
}