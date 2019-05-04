using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class ArdaListViewModel
    {
        public List<DtoArda> Ardas { get; set; }

        public ArdaListViewModel()
        {
            Ardas = new List<DtoArda>();
        }
    }
}