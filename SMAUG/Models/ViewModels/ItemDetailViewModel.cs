﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class ItemDetailViewModel
    {
        public string Ite_Id { get; set; }

        [Display(Name = "Item Type")]
        public string Ite_Type { get; set; }
        [Display(Name = "Item Name")]
        public string Ite_Name { get; set; }
        [Display(Name = "Item collection")]
        public string Ite_Collection { get; set; }
        [Display(Name = "Edition")]
        public string Ite_Edition { get; set; }
        [Display(Name = "Editor")]
        public string Ite_Editor { get; set; }
        [Display(Name = "ISBN")]
        public string Ite_ISBN { get; set; }
        [Display(Name = "Made in")]
        public Nullable<short> Ite_ProdDate { get; set; }

        [Display(Name = "Inspired by")]
        public virtual ICollection<Publication> Inspires { get; set; }
        [Display(Name = "Made by")]
        public virtual ICollection<Person> Maker { get; set; }
        [Display(Name = "Inspired by")]
        public virtual ICollection<Arda> ReferedTo { get; set; }
    }
}