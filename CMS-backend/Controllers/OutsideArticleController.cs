using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSBackend.BUS;
using CMSBackend.Models.Entity.OutsideArticle;
using Common.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMSBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OutsideArticleController : ControllerBase
    {
        private OutsideArticleBUS _outsideArticleBUS = OutsideArticleBUS.GetOutsideArticleBUSInstance();
        // GET: api/OutsideArticle
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OutsideArticle/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOutsideArticleById(int id)
        {
            // return Ok(_outsideArticleBUS.GetOutsideArticleById(id));
            return null;
        }


        // POST: api/OutsideArticle
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OutsideArticle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        public IActionResult GetAllOutsideArticle()
        {
            return Ok(_outsideArticleBUS.GetAll());
        }

    }
}
