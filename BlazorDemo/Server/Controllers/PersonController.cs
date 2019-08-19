using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> Getpeople()
        {
                      return new List<PersonModel> 
                      {
                        new PersonModel{ FirstName = "Emilio", LastName = "Barrera" , AccountBalance = 19.45M },
                        new PersonModel{ FirstName = "Tim", LastName = "Corey" , AccountBalance = 20.45M },
                        new PersonModel{ FirstName = "Emiliana", LastName = "Tom" , AccountBalance = 50.45M },
                        new PersonModel{ FirstName = "Chalsay", LastName = "Waymar" , AccountBalance = 105.45M },

                      };

           
        }

        [HttpPost]
         public void Post(PersonModel model)
        {

        }
    }
}