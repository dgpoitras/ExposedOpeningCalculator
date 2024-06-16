
namespace ExposedOpeningCalculator
{
    internal record ResidentialData
    {
        public static readonly int[] ZAreaList = { 30, 40, 50, 100, 101 };

        public static readonly Dictionary<int, string> YSelection = new Dictionary<int, string>
        {
            {0, "y_30" },
            {1, "y_40" },
            {2, "y_50" },
            {3, "y_100" },
            {4, "y_101" }
        };

        public static readonly double[] XLimitList = {
            0.0,
            1.2,
            1.5,
            2.0,
            4.0,
            6.0,
            8.0,
            10.0,
            12.0,
            16.0,
            20.0,
            25.0
        };

        public static readonly double[] Y30 = {
            0,
            7,
            9,
            12,
            39,
            88,
            100,
            100,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y40 = {
            0,
            7,
            8,
            11,
            32,
            69,
            100,
            100,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y50 = {
            0,
            7,
            8,
            10,
            28,
            57,
            100,
            100,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y100 = {
            0,
            7,
            8,
            9,
            18,
            34,
            56,
            84,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y101 = {
            0,
            7,
            7,
            8,
            12,
            19,
            28,
            40,
            55,
            92,
            100,
            100
        };
    }
}
