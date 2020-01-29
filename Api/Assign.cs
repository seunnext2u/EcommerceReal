using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcommerceReal.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceReal.Api
{

 
    [Route("api/[controller]")]
    public class Assign : Controller
    {
        private readonly EcommerceReal.Data.ApplicationDbContext _context;
        public Assign (EcommerceReal.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet("MaincartAll")]
        public  List<MainCategory> GetMaincartAllAsync()
        {


            var MainCategory =  _context.mainCategories.ToList();


            return MainCategory;
            //var ListofAdrss = new List<Address>
            //{
            //    new Address
            //    {
            //        Id = 1,
            //        ActualAddress = "gbogbo"
            //    },
            //    new Address
            //    {
            //        Id = 2,
            //        ActualAddress = "gbogbo Oluwaseun"
            //    }
            //};
            //var requestaddress = ListofAdrss.FirstOrDefault(m => m.Id == id);
            //return requestaddress;
        }

        [HttpGet("MainCartByID")]
        public MainCategory GetMainCartById([FromQuery]int id)
        {
            var CartById = _context.mainCategories.FirstOrDefault(m => m.Id == id);
            return CartById;
        }
        [HttpGet("SubMaincartAll")]
        public List<SubCategory> GetSubMaincartAllAsync()
        {


            var MainCategory = _context.SubCategories.ToList();


            return MainCategory;
        
        }

        [HttpGet("SubCartByID")]
        public SubCategory GetSubCartById([FromQuery]int id)
        {
            var CartById = _context.SubCategories.FirstOrDefault(m => m.Id == id);
            return CartById;
        }
        [HttpGet("SubCartByMain")]
        public List<SubCategory> GetSubCartByMain([FromQuery]int id)
        {
            var CartById = _context.SubCategories.Where(m => m.MainCategory.Id == id).ToList();
          
            return CartById;
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
