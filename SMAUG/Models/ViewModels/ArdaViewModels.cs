using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class ArdaViewModels
    {
        public class ArdaListViewModel
        {
            public List<DtoArda> Ardas { get; set; }

            public ArdaListViewModel()
            {
                Ardas = new List<DtoArda>();
            }
        }

        public class ArdaDetailViewModels
        {
            public DtoArda arda;
        }

        public class ArdaCreateViewModel
        {
            public string Ard_Name { get; set; }
            public string Ard_Type { get; set; }
            public string Ard_Race { get; set; }
            public string Ard_People { get; set; }
            public Nullable<int> Ard_FirstAppearance { get; set; }
            public string Ard_Gender { get; set; }
        }
    }
}