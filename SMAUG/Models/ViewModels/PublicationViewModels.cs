using SMAUG.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMAUG.Models.ViewModels
{
    public class PublicationViewModels
    {
        public class PublicationListViewModel
        {
            public List<DtoPublication> Publications { get; set; }

            public PublicationListViewModel()
            {
                Publications = new List<DtoPublication>();
            }
        }

        public class PublicationDetailViewModels
        {
            public DtoPublication publication;
        }

        public class PublicationCreateViewModel
        {
            [Display(Name = "Title")]
            public string Pub_Title { get; set; }
            [Display(Name = "Published in")]
            public Nullable<short> Pub_Date { get; set; }
            [Display(Name = "Series Title")]
            public string Pub_SeriesTitle { get; set; }
            [Display(Name = "Volume")]
            public Nullable<int> Pub_Volume { get; set; }

            [Display(Name = "Media type")]
            public string Pub_Type { get; set; }
            [Display(Name = "Subcreated by")]
            public virtual ICollection<Person> Subcreator { get; set; }
            [Display(Name = "Adapted by")]
            public ICollection<DtoPerson> Adaptors { get; set; }
            [Display(Name = "Inspired")]
            public ICollection<DtoItem> Inspireds { get; set; }
            [Display(Name = "Introduced")]
            public virtual ICollection<Publication> Introduceds { get; set; }
            [Display(Name = "Adapted by")]
            public ICollection<DtoArda> Adapteds { get; set; }
        }
    }
}