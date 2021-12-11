using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PointsBet.Test
{
    [Route("api/[resultFixture]")]
    [ApiController]
    public class ResultFixtureController : ControllerBase
    {
        private readonly ILogger _loggerInstance;
        private readonly IValidateFixture _fixtureValidator;
        private readonly IDatabaseConnector _dbConnector;

        public ResultFixtureController(ILogger loggerInstance, IValidateFixture fixtureValidator, IDatabaseConnector dbConnector)
        {
            _loggerInstance = loggerInstance;
            _fixtureValidator = fixtureValidator;
            _dbConnector = dbConnector;
        }
        [HttpGet]
        public ObjectResult GetFixtureResult(string id)
        {
            IDatabase database = _dbConnector.ConnectDB("dabasetoConnect/repo");
            if (database.FixtureExists(id))
            {
                _loggerInstance.Log(LogLevel.Information,"Getting result for fixture"+id);
                Fixture result = database.GetFixture(id);
                return Ok(result);
            }

            return BadRequest("RESULT AWAITED!!!");
        }
    }
}