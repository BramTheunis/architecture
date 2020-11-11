using System.Collections.Generic;
using BasicRestAPI.Models;
using BasicRestAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BasicRestAPI.Controllers
{
    [Route("api/bouquets")]
    [ApiController]
    public class BouquetsController : ControllerBase
    {
        private readonly MockBasicRestAPIRepo _repository = new MockBasicRestAPIRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Bouquet>> GetAllBouquets()
        {
            var bouquetItems = _repository.GetBouquet();

            return Ok(bouquetItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Bouquet> GetBouquestById(int id)
        {
            var bouquetItem = _repository.GetBouquetById(id);

            return Ok(bouquetItem);
        }
    }
}