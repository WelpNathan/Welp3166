using WelpNathan.Welp3166;
using Xunit;

namespace WelpNathan.Welp3166Tests
{
    public class CountryTests
    {
        /// <summary>
        /// Reference's how many current countries there are
        /// according to the standard.
        /// </summary>
        private const int CountryCount = 249;

        /// <summary>
        /// Reference's the standard's numeric ID length.
        /// </summary>
        private const int CountryIdLength = 3;

        /// <summary>
        /// Reference's the standard's alpha 2 length.
        /// </summary>
        private const int Alpha2Length = 2;

        /// <summary>
        /// Reference's the standard's alpha 3 length.
        /// </summary>
        private const int Alpha3Length = 3;

        /// <summary>
        /// Ensures that the countries hard coded in the application
        /// matches the current country count.
        /// </summary>
        [Fact]
        public void Countries_ShouldContainValidCountryNumbers()
        {
            Assert.True(Country.Countries.Count == CountryCount);
        }
        
        /// <summary>
        /// Loops through all of the countries to ensure that they have
        /// a valid identifier.
        /// </summary>
        [Fact]
        public void Countries_ShouldContainValidIds()
        {
            Assert.All(Country.Countries, country => Assert.Equal(CountryIdLength, country.Id.Length));
        }

        /// <summary>
        /// Loops through all of the countries to ensure that they have
        /// a valid alpha-2 code.
        /// </summary>
        [Fact]
        public void Countries_ShouldContainValidAlpha2()
        {
            Assert.All(Country.Countries, country => Assert.Equal(Alpha2Length, country.Alpha2.Length));
        }

        [Fact]
        public void Countries_ShouldContainValidAlpha3()
        {
            Assert.All(Country.Countries, country => Assert.Equal(Alpha3Length, country.Alpha3.Length));
        }

        /// <summary>
        /// Ensures that the Afghanistan entry is correct.
        /// </summary>
        [Fact]
        public void AfghanistanEntity_ShouldBeValid()
        {
            var entry = Country.Countries.Find(x => x.EnShort == "Afghanistan");
            const string alpha2 = "AF";
            const string alpha3 = "AFG";
            const string id = "004";

            Assert.True(entry != null && entry.Alpha2 == alpha2 && entry.Alpha3 == alpha3 && entry.Id == id);
        }
    }
}