using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Edmx
{
    public class PublicationModel
    {
        public int Per_Id { get; set; }
        [Display(Name = "Title")]
        public string Per_Name { get; set; }
    }
}