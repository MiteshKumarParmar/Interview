using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsBet.Test
{
    public interface IValidateFixture
    {
        FixtureValidationResult Validate(Fixture fixtureToValidate);

        bool IsFixtureAlreadyCreated(string id);
    }

    public enum FixtureValidationResult
    {
        ValidFixture,
        InValidFixture
    };
}
