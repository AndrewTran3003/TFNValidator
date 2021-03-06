using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFNValidator.Helpers;
using TFNValidator.Services.Abstract;

namespace TFNValidator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TfnValidatorController:ControllerBase
    {
        private readonly ITfnService _tfnService;
        public TfnValidatorController(ITfnService tfnService)
        {
            _tfnService = tfnService;
        }
        [HttpGet]
        [Route("Validate")]
        public IActionResult ValidateTfnString (string tfnString)
        {
            OperationResultMessage<object> tfnValidationMessage = _tfnService.ValidateTfnString(tfnString);
            if (tfnValidationMessage.Status != OperationResultMessageStatus.Success)
            {
                return BadRequest(tfnValidationMessage.Message);
            }
            return Ok(tfnValidationMessage.Message);

        }
    }
}
