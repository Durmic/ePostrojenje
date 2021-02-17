using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Model.Requests
{
    public class RacuniSearchRequest
    {
        public int? KupacId { get; set; }
        public bool? Placen { get; set; }
    }
}
