using Microsoft.Extensions.Logging;
using System.Data;
using System.Reflection;


namespace ExposedOpening
{
    public class ExposeOpeningCalculator
    {
         public double[] GetValues(double exposedFace)
        {
            int face = ResidentialData.ZAreaList[0];
            foreach (int v in ResidentialData.ZAreaList)
            {
                if (v <= exposedFace) face = v;
            }

            var faceIndex = Array.IndexOf(ResidentialData.ZAreaList, face);

            if (exposedFace != face) return CalcNewValues(exposedFace, faceIndex);

            return ResidentialData.YSelection[faceIndex]();
        }

        private static double[] CalcNewValues(double faceValue, int zIndex)
        {
            var minZ = ResidentialData.ZAreaList[zIndex];
            var maxZ = ResidentialData.ZAreaList[zIndex + 1];

            var zMargin = maxZ - minZ;
            var fix = faceValue - minZ;
            var realMargin = fix/zMargin;

            var newY = faceValue;
            var minY = ResidentialData.YSelection[zIndex]();
            var maxY = ResidentialData.YSelection[zIndex + 1]();

            double[] newXList = {};
            for (int i = 0; i < ResidentialData.XLimitList.Length; i++)
            {
                var minX = minY[i];
                var maxX = maxY[i];
                var xMargin = minX - maxX;
                var newX = minX - xMargin * realMargin;
                newXList.Append(newX);
            }

            return newXList;
        }

        public double CalcPoint(double distLimit, double[] area)
        {
            if (distLimit < ResidentialData.XLimitList[1]) return 0.00;
            if (distLimit > ResidentialData.XLimitList.Max()) return 100;
            var x = ResidentialData.XLimitList;
            var y = area;
            return new LinearInterpolate().Interp(distLimit, x, y);
        }


    }
}
