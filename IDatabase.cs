namespace PointsBet.Test
{
    public interface IDatabase
    {
        void SaveFixture(Fixture newFixtureToBeAdded);

        Fixture GetFixture(string id);

        bool FixtureExists(string id);
    }
}