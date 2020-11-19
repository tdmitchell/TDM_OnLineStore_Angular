using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TDM_OnLineStore.Dominium.Models.Entity;
using TDM_OnLineStore.Dominium.Models.Interface;

namespace TDM_OnLineStore.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #region 
        //CREATE

        //READ
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.GetAll());
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            try
            {
                _productRepository.Add(product);
                return Created("api/product", product);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
        //UPDATE

        //DELETE


        #endregion
    }
}
