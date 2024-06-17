namespace ExposedOpening
{
    internal class LinearInterpolate
    {
        public double Interp(double x, double[] xp, double[] fp)
        {
            // Perform linear interpolation
            if (xp.Length != fp.Length || xp.Length < 2)
                throw new ArgumentException("Arrays xp and fp must be of the same length and at least of length 2.");

            int i = Array.BinarySearch(xp, x);

            if (i < 0)
            {
                i = ~i;

                if (i == 0)
                    return fp[0];
                else if (i == xp.Length)
                    return fp[xp.Length - 1];
                else
                {
                    double x0 = xp[i - 1];
                    double x1 = xp[i];
                    double f0 = fp[i - 1];
                    double f1 = fp[i];

                    return f0 + (f1 - f0) * (x - x0) / (x1 - x0);
                }
            }
            else
            {
                return fp[i];
            }
        }
    }
}
