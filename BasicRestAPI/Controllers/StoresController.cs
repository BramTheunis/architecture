using System.Collections.Generic;
using BasicRestAPI.Models;
using BasicRestAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BasicRestAPI.Controllers
{
    [Route("api/stores")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IBasicRestAPIRepo _repository;

        public StoresController(IBasicRestAPIRepo repository)
        {
            _repository = repository;
        }

       //  private readonly MockBasicRestAPIRepo _repository = new MockBasicRestAPIRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Store>> GetAllStores()
        {
            var storeItems = _repository.GetStore();

            return Ok(storeItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Store> GetStoreById(int id)
        {
            var storeItem = _repository.GetStoreById(id);

            return Ok(storeItem);
        }
    }
}