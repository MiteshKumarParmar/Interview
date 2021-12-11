namespace PointsBet.Test
{
    public class ValidateFixture : IValidateFixture
    {
        public FixtureValidationResult Validate(Fixture fixtureToValidate)
        {
            return FixtureValidationResult.ValidFixture;
        }

        public bool IsFixtureAlreadyCreated(string id)
        {
           //Write logic to check db if already a fixture with this ID exists
           return true;
        }
    }
}
