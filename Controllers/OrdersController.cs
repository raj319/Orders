using System;
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
       
        [HttpGet]
        public String Get()
        {
            return "orders returned";
        }

        [HttpGet("{id}")]
        public String Get(int id)
        {
            return "orders returned";
        }

        [HttpGet("{id}/lol")]
        public String GetFilter(int id)
        {
            return "orders returned";
        }

        [HttpPost]
        public String Create()
        {
            return "orders created";
        }

        [HttpPut]
        public String Up()
        {
            return "orders updated";
        }

        [HttpDelete]
        public String Del()
        {
            return "orders deleted";
        }
    }
}
