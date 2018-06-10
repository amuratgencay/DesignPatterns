using System;

namespace DesignPattern.Entity.StructuralPatterns.AdapterPattern
{
    public class Compound
    {
        public string Chemical { get; set; }
        public float BoilingPoint { get; set; }
        public float MeltingPoint { get; set; }
        public double MolecularWeight { get; set; }
        public string MoleculerFormula { get; set; }

        // Constructor

        public Compound(string chemical)
        {
            Chemical = chemical;
        }

        public override string ToString()
        {
            return $"\tCompound: {Chemical}";
        }
    }
}
