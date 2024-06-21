
namespace ExposedOpening
{
    internal record CommercialData
    {
        public static readonly int[] ZAreaList = { 30, 40, 50, 100, 101 };

        public static readonly Dictionary<int, Func<double[]>> YSelection = new Dictionary<int, Func<double[]>>
        {
            {0, () => Y30 },
            {1, () => Y40 },
            {2, () => Y50 },
            {3, () => Y100 },
            {4, () => YOver100 }
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
            4,
            4,
            6,
            20,
            44,
            80,
            100,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y40 = {
            0,
            4,
            4,
            6,
            16,
            34,
            61,
            97,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y50 = {
            0,
            4,
            4,
            5,
            14,
            29,
            50,
            79,
            100,
            100,
            100,
            100
        };

        public static readonly double[] Y100 = {
            0,
            4,
            4,
            4,
            9,
            17,
            28,
            42,
            60,
            100,
            100,
            100
        };

        public static readonly double[] YOver100 = {
            0,
            4,
            4,
            4,
            6,
            10,
            14,
            20,
            27,
            46,
            70,
            100
        };
    }
}
