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

        public DtoPerson Author { get; set; }
        public DtoItem Item { get; set; }
        public DtoArda Arda { get; set; }
    }
}