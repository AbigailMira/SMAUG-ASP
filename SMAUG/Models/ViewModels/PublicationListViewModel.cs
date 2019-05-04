using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class PublicationListViewModel
    {
        public List<DtoPublication> Publications { get; set; }

        public PublicationListViewModel()
        {
            Publications = new List<DtoPublication>();
        }
    }
}