namespace DesignPattern.Entity.StructuralPatterns.AdapterPattern
{
    public class Compound
    {
        // Constructor

        public Compound(string chemical)
        {
            Chemical = chemical;
        }

        public string Chemical { get; set; }
        public float BoilingPoint { get; set; }
        public float MeltingPoint { get; set; }
        public double MolecularWeight { get; set; }
        public string MoleculerFormula { get; set; }

        public override string ToString()
        {
            return $"\tCompound: {Chemical}";
        }
    }
}