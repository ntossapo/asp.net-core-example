using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace asp_net_core_example.Controllers
{
    [Route("hello")]
    public class myController : Controller
    {
        [HttpGet("{value}")]
        public string Fibonacci(int value)
        {
            return "Hello this is .NET core " + value;
        }

        public static bool isFibonacci(int target)
        {
            bool result = false;
            int value1 = 1;
            int value2 = value1;
        
            while(value2 <= target)
            {
                int temp = value2;
                value2 += value1;
                value1 = temp;
            }

            if(value1 == target)
            {
                result = true;
            }

            return result;
        }
    }
}
