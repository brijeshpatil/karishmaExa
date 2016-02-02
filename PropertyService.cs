using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppForCloud
{
    public class PropertyService : DataService
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int StateID { get; set; }
        public string StateName { get; set; }

        public int CityID { get; set; }
        public string CityName { get; set; }
    }
}