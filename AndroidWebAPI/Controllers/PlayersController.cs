using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AndroidWebAPI.Controllers
{
    public class PlayersController : ApiController
    {
        STDb db;
        public PlayersController()
        {
            db = new STDb();
        }

       [HttpGet]
       public IEnumerable<Players> GetPlayers()
        {
            return db.Players.ToList();
        }

        // GET api/values
        public IEnumerable<Players> Get()
        {
            return db.Players.ToList();
        }

        // GET api/values/5
        public Players Get(int id)
        {
            Players players = db.Players.Find(id);
            return players;
        }

        // POST api/values
        public void Post([FromBody]Players value)
        {
            db.Entry(value).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Players value)
        {
            db.Entry(value).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Players players = db.Players.Find(id);
            db.Players.Remove(players);
            db.SaveChanges();
        }


    }
}
