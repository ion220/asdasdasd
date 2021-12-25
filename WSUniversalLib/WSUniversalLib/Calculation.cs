namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            Dictionary<int, double> ProductTypes = new Dictionary<int, double>();
            ProductTypes.Add(1, 1.1);
            ProductTypes.Add(2, 2.5);
            ProductTypes.Add(3, 8.43);

            Dictionary<int, double> MaterialTypes = new Dictionary<int, double>();
            MaterialTypes.Add(1, 0.003);
            MaterialTypes.Add(2, 0.0012);

            try
            {
                var result = width * length * ProductTypes[productType] * count;
                result = result + (result * MaterialTypes[materialType]);
                return Convert.ToInt32(result);
            }
            catch
            {
                return -1;
            }
        }
    }
}