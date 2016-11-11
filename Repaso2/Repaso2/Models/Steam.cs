using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repaso2.Models
{
    public class Steam
    {
        public int SteamId { get; set; }
        public int Employees { get; set; }
        public string Games { get; set; }
        public DateTime CreationDate { get; set; }
    }
}