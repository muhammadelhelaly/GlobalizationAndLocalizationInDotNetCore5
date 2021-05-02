using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace GlobalizationAndLocalizationInDotNetCore5.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _localizer;

        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var username = "Muhammad ElHelaly";
            return Ok(_localizer["Welcome", username].Value);
        }
    }
}