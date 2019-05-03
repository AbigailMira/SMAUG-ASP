using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SMAUG.Dto;

namespace SMAUG.Models
{
    public class ItemViewModel
    {
        public List<DtoItem> Items { get; set; }

        public ItemViewModel()
        {
            Items = new List<DtoItem>();
        }
    }
}
