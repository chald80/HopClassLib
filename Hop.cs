using System;
using System.Reflection.Metadata;

namespace HopClassLib
{
    public class Hop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double AlphaAcid { get; set; }
        public int HarvestYear { get; set; }
        public int Price { get; set; }

        public Hop(int id, string name, double alphaAcid, int harvestYear, int price)
        {
            Id = id;
            Name = name;
            AlphaAcid = alphaAcid;
            HarvestYear = harvestYear;
            Price = price;
        }

        public Hop()
        {
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(AlphaAcid)}: {AlphaAcid}, {nameof(HarvestYear)}: {HarvestYear}, {nameof(Price)}: {Price}";
        }
    }
}
