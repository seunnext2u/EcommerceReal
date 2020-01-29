using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceReal.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceReal.Api
{
   public class viewaddress
    {
        public string ActualAddress { get; set; }
    }
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        //[HttpGet("{id}")]
        [HttpGet("ByName")]
        public string Get([FromQuery]int id, [FromQuery] string name)
        {
            return $"Your Nam is {name} and your id is {id}";

            //var firstaddres = new Address()
            //{

            //}
            //return firstaddres;
        }

        [HttpGet("AddressbyID")]
        public  Address GetAddressById([FromQuery]int id)
        {


            var ListofAdrss = new List<Address>
            {
                new Address
                {
                    Id = 1,
                    ActualAddress = "gbogbo"
                },
                new Address
                {
                    Id = 2,
                    ActualAddress = "gbogbo Oluwaseun"
                }
            };
            var requestaddress = ListofAdrss.FirstOrDefault(m => m.Id == id);
            return requestaddress;
        }

        [HttpGet("AddressAll")]
        public List<Address> GetAddressAll()
        {


            var ListofAdrss = new List<Address>
            {
                new Address
                {
                    Id = 1,
                    ActualAddress = "gbogbo"
                },
                new Address
                {
                    Id = 2,
                    ActualAddress = "gbogbo Oluwaseun"
                }
            };
            //var requestaddress = ListofAdrss.FirstOrDefault(m => m.Id == id);
            return ListofAdrss;
        }


        [HttpGet("AddressAllonly")]
        public List<viewaddress> GetAddressAlOnly()
        {


            var ListofAdrss = new List<Address>
            {
                new Address
                {
                    Id = 1,
                    ActualAddress = "gbogbo"
                },
                new Address
                {
                    Id = 2,
                    ActualAddress = "gbogbo Oluwaseun"
                }
            };
            //var requestaddress = ListofAdrss.FirstOrDefault(m => m.Id == id);

            var data = ListofAdrss.Select(x => new viewaddress
            {
                ActualAddress = x.ActualAddress
            }).ToList();

            //var dd = new List<viewaddress>();
            //foreach( var item in ListofAdrss )
            //{
            //    var ddd = new viewaddress();
            //    ddd.ActualAddress = item.ActualAddress;
            //    dd.Add(ddd);
            //}

            return data;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
