using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE_API.DataAccess;
using CORE_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CORE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalisanController : ControllerBase
    {
        ICalisanDal _calisanDal;
        public CalisanController(ICalisanDal calisan)
        {
            _calisanDal= calisan;
        }

        [HttpGet]
        public IActionResult result()
        {
            var products = _calisanDal.GetList();
            return Ok(products);
        } 
    }
}