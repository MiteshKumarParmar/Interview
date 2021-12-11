using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PointsBet.Test
{
    [Route("api/[updateFixture]")]
    [ApiController]
    public class UpdateFixtureController : ControllerBase
    {
        private readonly ILogger _loggerInstance;
        private readonly IValidateFixture _fixtureValidator;
        private readonly IDatabaseConnector _dbConnector;

        public UpdateFixtureController(ILogger loggerInstance, IValidateFixture fixtureValidator, IDatabaseConnector dbConnector)
        {
            _loggerInstance = loggerInstance;
            _fixtureValidator = fixtureValidator;
            _dbConnector = dbConnector;
        }
        [HttpPost]
        public StatusCodeResult UpdateFixture([FromBody] Fixture alreadyCreatedFixture)
        {
            _loggerInstance.Log(LogLevel.Information,"Update request received for fixture with ID"+alreadyCreatedFixture.Payload.Id);
            if (_fixtureValidator.IsFixtureAlreadyCreated(alreadyCreatedFixture.Payload.Id.ToString()))
            {
                lock (new object())
                {
                    IDatabase database = _dbConnector.ConnectDB("dabasetoConnect/repo");
                    database.SaveFixture(alreadyCreatedFixture);
                    //logging logic can be further optimized below here
                    _loggerInstance.Log(LogLevel.Information, "Update fixture with new value" + alreadyCreatedFixture.Payload.Markets[0].Price);
                    _loggerInstance.Log(LogLevel.Information, "Update fixture with new value" + alreadyCreatedFixture.Payload.Markets[1].Price);
                    return Ok();
                }
            }

            return BadRequest();
        }
    }
}