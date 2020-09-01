using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RimDevFeatureFlagsDemo.FeatureFlags;
using RimDevFeatureFlagsDemo.Models;

namespace RimDevFeatureFlagsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private readonly LatteFeatureFlag _latteFeatureFlag;
        private readonly EspressoFeatureFlag _espressoFeatureFlag;
        private readonly CappuccinoFeatureFlag _cappuccinoFeatureFlag;
        private readonly ILogger<CoffeeController> _logger;

        public CoffeeController(
            LatteFeatureFlag latteFeatureFlag,
            EspressoFeatureFlag espressoFeatureFlag,
            CappuccinoFeatureFlag cappuccinoFeatureFlag,
            ILogger<CoffeeController> logger)
        {
            _logger = logger;
            _latteFeatureFlag = latteFeatureFlag;
            _espressoFeatureFlag = espressoFeatureFlag;
            _cappuccinoFeatureFlag = cappuccinoFeatureFlag;
        }

        [HttpGet]
        public IEnumerable<string> GetCoffees()
        {
            if (_latteFeatureFlag.Value)
            {
                yield return nameof(CoffeeType.Latte);
            }

            if (_espressoFeatureFlag.Value)
            {
                yield return nameof(CoffeeType.Espresso);
            }

            if (_cappuccinoFeatureFlag.Value)
            {
                yield return nameof(CoffeeType.Cappuccino);
            }
        }
    }
}
