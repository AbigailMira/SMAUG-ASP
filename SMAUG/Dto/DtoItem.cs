using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SMAUG.Dto
{
    public class DtoItem

    {
        public int Ite_Id { get; set; }        
        public string Ite_Type { get; set; }        
        public string Ite_Name { get; set; }        
        public string Ite_Collection { get; set; }        
        public string Ite_Edition { get; set; }        
        public string Ite_Editor { get; set; }        
        public string Ite_ISBN { get; set; }        
        public Nullable<short> Ite_ProdDate { get; set; }

        public ICollection<DtoPerson> Makers { get; set; }

    }
}