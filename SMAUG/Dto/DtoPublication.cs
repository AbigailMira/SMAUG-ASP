using SMAUG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoPublication
    {
        public int Pub_Id { get; set; }
        public string Pub_Title { get; set; }
        public Nullable<short> Pub_Date { get; set; }
        public string Pub_SeriesTitle { get; set; }
        public Nullable<int> Pub_Volume { get; set; }
        public Nullable<int> Pub_Author { get; set; }
        public string Pub_Type { get; set; }

        public ICollection<DtoPerson> Subcreators { get; set; }
        public ICollection<DtoPerson> Adaptors { get; set; }
        public ICollection<DtoItem> Inspireds { get; set; }
        public ICollection<DtoArda> Introduceds { get; set; }
        public ICollection<DtoArda> Adapteds { get; set; }

        public DtoPublication()
        {
        }
    }

    
}