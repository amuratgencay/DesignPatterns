using DesignPattern.Entity.StructuralPatterns.AdapterPattern;

namespace DesignPattern.BLL.StructuralPatterns.AdapterPattern
{
    public class RichCompound : Compound
    {
        private readonly ChemicalDatabank _chemicalDatabank = new ChemicalDatabank();

        public RichCompound(CompoundType chemical) : base(chemical.ToString())
        {
        }

        public RichCompound(string chemical, float boilingPoint, float meltingPoint, double molecularWeight,
            string moleculerFormula) : base(chemical)
        {
            BoilingPoint = boilingPoint;
            MeltingPoint = meltingPoint;
            MolecularWeight = molecularWeight;
            MoleculerFormula = moleculerFormula;
        }

        public override string ToString()
        {
            var richCompound = _chemicalDatabank.GetCompound(Chemical);

            return $"{base.ToString()}\n"
                   + $"\t\tFormula: {richCompound.MoleculerFormula}\n"
                   + $"\t\tWeight: {richCompound.MolecularWeight}\n"
                   + $"\t\tMelting Pt: {richCompound.MeltingPoint}\n"
                   + $"\t\tBoiling Pt: {richCompound.BoilingPoint}\n";
        }
    }
}