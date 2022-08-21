using Math.Models;
using Math.Service;
using Microsoft.AspNetCore.Mvc;

namespace Math.Controllers
{
    /// <summary>
    /// Math Operations Controller
    /// </summary>
    [ApiController]
    [Route("operations")]
    public class Operations : Controller
    {
        private readonly IMathOperationsService _mathOperationService;

        /// <summary>
        /// Math Operations constructor
        /// </summary>
        /// <param name="mathOperationService"></param>
        public Operations(IMathOperationsService mathOperationService)
        {
            _mathOperationService = mathOperationService;
        }

        /// <summary>
        /// Given list of numbers and a quantifier (how many) provides min number(s)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("min")]
        public ActionResult<IEnumerable<double>> CalculateMin([FromBody] MinRequestViewModel request)
        {
            return Ok(_mathOperationService
                .CalculateMinNumbers(request.Numbers, request.Quantifier));
        }

        /// <summary>
        /// Given list of numbers and a quantifier (how many) provides max number(s)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("max")]
        public ActionResult<IEnumerable<double>> CalculateMax([FromBody] MaxRequestViewModel request)
        {
            return Ok(_mathOperationService
                .CalculateMaxNumbers(request.Numbers, request.Quantifier));
        }

        /// <summary>
        /// Given list of numbers calculates their average
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("avg")]
        public ActionResult<double> CalculateAvg([FromBody] AverageRequestViewModel request)
        {
            return Ok(_mathOperationService
                .CalculateAverage(request.Numbers));
        }

        /// <summary>
        /// Given list of numbers calculates their median
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("median")]
        public ActionResult<double> CalculateMedian([FromBody] MedianRequestViewModel request)
        {
            return Ok(_mathOperationService
                .CalculateMedian(request.Numbers));
        }

        /// <summary>
        /// Given list of numbers and quantifier 'q', compute the qth percentile of the list elements
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("percentile")]
        public ActionResult<double> CalculatePercentile([FromBody] PercentileRequestViewModel request)
        {
            return Ok(_mathOperationService
                .CalculatePercentile(request.Numbers, request.Quantifier));
        }
    }
}
