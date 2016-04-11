using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApiContrib.ModelBinders;

namespace MvcStyleBindingProblem
{
    [MvcStyleBinding]
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            Console.WriteLine("Get");
            return new[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string GetById(int id)
        {
            Console.WriteLine("GetById: " + id);
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
            Console.WriteLine("Post: " + value);
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
            Console.WriteLine("Put: " + id);
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            Console.WriteLine("Delete: " + id);
        }
    }
}
