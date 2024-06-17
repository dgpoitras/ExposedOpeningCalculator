
namespace ExposedOpening
{
    internal record ResidentialData
    {
        public static readonly int[] ZAreaList = { 30, 40, 50, 100, 101 };

        public static readonly Dictionary<int, Func<double[]>> YSelection = new Dictionary<int, Func<double[]>>
        {
            {0, () => Y30 },
            {1, () => Y40 },
            {2, () => Y50 },
            {3, () => Y100 },
            {4, () => Y101 }
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
