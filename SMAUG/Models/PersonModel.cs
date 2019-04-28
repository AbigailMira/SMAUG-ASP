using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Edmx
{
    public class PersonModel
    {
        public int Per_Id { get; set; }
        [Display(Name = "First Name")]
        public string Per_FirstName  { get; set; }
        [Display(Name = "Last Name")]
        public string Per_LastName { get; set; }
    }
}