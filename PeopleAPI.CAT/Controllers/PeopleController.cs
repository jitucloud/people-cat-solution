using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PeopleCAT.API.Online.Controllers
{
    [RoutePrefix("api/peoples")]

    public class PeopleController : ApiController
    {

        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAllPeople()
        {

            // Call People Manager to get all people
            return Ok("all people string");
        }


        [Route("{id:int}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetPeopleByID(int id)
        {

            // Call People Manager to get individual people
            return Ok(string.Format("individual people string for id {0}", id.ToString()));
        }
    }
}
