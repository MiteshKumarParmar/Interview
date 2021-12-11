using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PointsBet.Test
{
    [Route("api/[createFixture]")]
    [ApiController]
    public class CreateFixtureController : ControllerBase
    {
        private readonly ILogger _loggerInstance;

        private readonly IValidateFixture _fixtureValidator;
        private readonly IDatabaseConnector _dbConnector;

        public CreateFixtureController(ILogger loggerInstance,IValidateFixture fixtureValidator,IDatabaseConnector dbConnector)
        {
            _loggerInstance = loggerInstance;
            _fixtureValidator = fixtureValidator;
            _dbConnector = dbConnector;
        }
        [HttpPost]
        public StatusCodeResult CreateEvent([FromBody] Fixture newFixture)
        {
            _loggerInstance.Log(LogLevel.Information,"Recieved new fixture creation request");
            if (_fixtureValidator.Validate(newFixture) == FixtureValidationResult.ValidFixture)
            {
                IDatabase database = _dbConnector.ConnectDB("dabasetoConnect/repo");
                if(!_fixtureValidator.IsFixtureAlreadyCreated(newFixture.Payload.Id.ToString()))
                {
                    database.SaveFixture(newFixture);
                }
                _loggerInstance.Log(LogLevel.Information,"New fixture created here");
                return Ok();
            }

            return BadRequest();

        }
    }
}