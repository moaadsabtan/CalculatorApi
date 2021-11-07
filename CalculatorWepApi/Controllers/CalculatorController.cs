using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorWepApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("Calculator")]
        public IActionResult Calculator([FromHeader] string calculatorType, [FromBody] TowNumber tsowNumber)
        {
            
            double res = 0;
            Boolean flag = false;
            if (calculatorType.Equals("+"))
            {
                res = tsowNumber.Number1 + tsowNumber.Number2;
                flag = true;
            }
            else
            {
                if (calculatorType.Equals("*"))
                {
                    res = tsowNumber.Number1 * tsowNumber.Number2;
                    flag = true;
                }
                else
                {
                    if (calculatorType.Equals("-"))
                    {
                        res = tsowNumber.Number1 - tsowNumber.Number2;
                        flag = true;
                    }
                    else
                    {
                        if (calculatorType.Equals("/"))
                        {
                            res = tsowNumber.Number1 / tsowNumber.Number2;
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
            }
            if (flag == true)
            {
               return Ok(flag);
            }
            else
            {
              return   BadRequest("Invalid");
            }
        }
    }
}
