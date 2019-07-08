using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class PersonViewModels
    {
        public class PersonListViewModel
        {
            public List<DtoPerson> Persons { get; set; }

            public PersonListViewModel()
            {
                Persons = new List<DtoPerson>();
            }
        }
        public class PersonDetailViewModel
        {
            public DtoPerson person;
        }

        public class PersonCreateViewModel
        {
            [Display(Name = "Lastname")]
            public string Per_LastName { get; set; }
            [Display(Name = "FirstName")]
            public string Per_FirstName { get; set; }
            [Display(Name = "FullName")]
            public string FullName { get { return string.Concat(Per_FirstName + " " + Per_LastName); } }
            [Display(Name = "Year of birth")]
            public Nullable<short> Per_Birth { get; set; }
            [Display(Name = "Year of Death")]
            public Nullable<short> Per_Death { get; set; }
            [Display(Name = "Job")]
            public string Per_Job { get; set; }
            [Display(Name = "Company")]
            public string Per_Company { get; set; }
            [Display(Name = "Interpreted")]
            public virtual ICollection<Arda> Interpreted { get; set; }
            [Display(Name = "Made")]
            public virtual ICollection<Item> Made { get; set; }
            [Display(Name = "Subcreated")]
            public virtual ICollection<Publication> Subcreated { get; set; }
            [Display(Name = "Adapted")]
            public virtual ICollection<Publication> Adapted { get; set; }
            [Display(Name = "Invented")]
            public virtual ICollection<Arda> Invented { get; set; }
        }
    }
}