using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationnn.Models;

namespace WebApplicationnn.Controllers
{
    public class TrainerController : ApiController
    {
        // GET: api/Trainer

        List<Trainer> lstTrainers = new List<Trainer>()
        {
            new Trainer(){Id=1, Name="Bhavika", Fieldexperience=5, TechnologyStack= new List<string>(){".Net", "C#","API"}},
            new Trainer(){Id=2,Name="Nehal",Fieldexperience=5, TechnologyStack= new List<string>(){"WPF", "C++","Java"}},
            new Trainer(){Id=3,Name="Sakshi", Fieldexperience=5, TechnologyStack= new List<string>(){"WPF", "MVM","PHP"}},

          
        };
        public IEnumerable<Trainer> Get()
        {
            return lstTrainers.ToList();
        }

        // GET: api/Trainer/5
        public Trainer Get(int id)
        {
           return lstTrainers.Where(t => t.Id == id).FirstOrDefault();
        }

        // POST: api/Trainer
        public void Post(Trainer trainer)
        {
            lstTrainers.Add(trainer);
        }

        // PUT: api/Trainer/5
        public void Put(int id, Trainer trainer)
        {
            var trainerFromDB = lstTrainers.Find(t=> t.Id== id);
            if (trainerFromDB != null)
                lstTrainers.Remove(trainerFromDB);
            lstTrainers.Add(trainer);

            
        }

        // DELETE: api/Trainer/5
        public void Delete(int id)
        {
            lstTrainers.Remove(lstTrainers.Find(t => t.Id == id));
        }
    }
}
