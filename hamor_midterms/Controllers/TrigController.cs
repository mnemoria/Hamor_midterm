using Microsoft.AspNetCore.Mvc;
using hamor_midterms.Models;

namespace hamor_midterms.Controllers
{
    [ApiController]
    [Route("trigo")]
    public class TrigController : ControllerBase
    {
        // Trigonometric Functions Solver
        static double TrigoSin(double x)
        {
            double sin = Math.Sin(x); 
            return sin;
        }

        static double TrigoCos(double x)
        {
            double cos = Math.Cos(x);
            return cos;
        }

        static double TrigoTan(double x) 
        {
            double tan = Math.Tan(x);  
            return tan;
        }

        [HttpPost]
        public ActionResult<TrigResult> Post([FromBody] TrigInput input)
        {
            var sin = TrigoSin(input.Angle);
            var cos = TrigoCos(input.Angle);
            var tan = TrigoTan(input.Angle);

            var result = new TrigResult { Sin = sin, Cos = cos, Tan = tan };
            
            return result;
        }
    }
}