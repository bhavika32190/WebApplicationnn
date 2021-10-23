using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationnn.Models
{
    public class Trainer
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public int Fieldexperience { get; set; }
        public IList<string> TechnologyStack { get; set; }
     }
}