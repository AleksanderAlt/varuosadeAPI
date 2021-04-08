using System.Collections.Generic;

namespace VaruosadeAPI.DTO
{
    public class PartsDTO
    {
        private Dictionary<string, int> stock = new Dictionary<string, int>();

        public string Serial { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double PriceVAT { get; set; }
        public string CarModel { get; set; }
        public Dictionary<string, int> Stock { get => stock; set => stock = value; }
    }
}
