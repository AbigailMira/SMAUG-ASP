﻿using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class PersonListViewModel
    {
        public List<DtoPerson> Persons { get; set; }

        public PersonListViewModel()
        {
            Persons = new List<DtoPerson>();
        }
    }
}