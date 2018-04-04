using PeopleCAT.API.Online.Interface;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace PeopleCAT.API.Online.Controllers
{
    /// <summary>
    /// Cat Controller for cat related endpoints
    /// </summary>
    [RoutePrefix("api/cats")]
    public class CatController : ApiController
    {
        private readonly ICatManager catManager;
        public CatController(ICatManager catManager)
        {
            this.catManager = catManager;
        }

        /// <summary>
        /// Get Cat Name List By Owner Gender
        /// </summary>
        /// <returns>{Male= [], Female=[]}</returns>
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetCatsNameByOwnerGender()
        {

            var catInfoByOwnerGender = await catManager.GetCatNameListByOwnerGender();
            if (catInfoByOwnerGender != null)
                return Ok(catInfoByOwnerGender);
            else
                return NotFound();
        }
    }
}
