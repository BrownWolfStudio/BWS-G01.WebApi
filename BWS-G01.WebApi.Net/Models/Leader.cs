namespace BWS_G01.WebApi.Net.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Leader
    {
        public int LeaderId { get; set; }

        public string Lastrank { get; set; }

        public string Playtime { get; set; }

        public string Rank { get; set; }

        public string Score { get; set; }

        public string Username { get; set; }
    }
}
