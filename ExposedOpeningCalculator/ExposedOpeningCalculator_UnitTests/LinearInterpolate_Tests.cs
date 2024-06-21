

namespace ExposedOpeningCalculator_UnitTests
{
    public class LinearInterpolate_Tests
    {
        public static IEnumerable<object[]> TestPosNumberGenerator()
        {
            yield return new object[] { 1.0, new double[] { 1, 2, 3, 4 }, new double[] { 1, 2, 3, 4 }, 1.0 };
            yield return new object[] { 2.0, new double[] { 1, 2, 3, 4 }, new double[] { 1, 2, 3, 4 }, 2.0 };
            yield return new object[] { 1.5, new double[] { 1, 2, 3, 4 }, new double[] { 1, 2, 3, 4 }, 1.5 };

        }

        private readonly ExposedOpening.LinearInterpolate _sut = new();

        [Theory]
        [MemberData(nameof(TestPosNumberGenerator))]
        public void Interp_Performs_linearInterpolation(double x, double[] y, double[] z, double expected)
        {
            var result = _sut.Interp(x, y, z);

            Assert.Equal(expected, result);

        }
    }
}
