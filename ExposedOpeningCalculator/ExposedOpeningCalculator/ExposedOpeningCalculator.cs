using Microsoft.Extensions.Logging;
using System.Data;


namespace ExposedOpeningCalculator
{
    public class ExposedOpeningCalculator
    {
        double maxArea = 30.0;
        double distLimit = 1.4;

        private static ResidentialData resData = new ResidentialData();
        


        static void Init( double maxArea, double distLimit)
        {
            double area = GetValues(maxArea);
            double result = CalcPoint(distLimit, area);
        }
        private static double GetValues(double exposedFace)
        {
            int face = resData.ZAreaList
            var result = 0.0;

            return result;
        }

        private static double CalcNewValues(double value, int index)
        {
            double area = 0.0;
            return area;
        }

        private static double CalcPoint(double distLimit, double area)
        {
            double result = 0.0;
            return result;
        }


    }
}
