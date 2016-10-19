using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repaso.Models
{
    public class Stuff
    {
        public int StuffId { get; set; }
        public string NameStuff { get; set; }
        public int SizeStuff { get; set; }
        public DateTime DateStuff { get; set; }
    }

}