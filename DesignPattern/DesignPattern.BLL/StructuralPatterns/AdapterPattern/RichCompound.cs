using System;
using DesignPattern.Entity.StructuralPatterns.AdapterPattern;

namespace DesignPattern.BLL.StructuralPatterns.AdapterPattern
{
    public class RichCompound : Compound
    {
        public RichCompound(CompoundType chemical) : base(chemical.ToString())
        {

        }
        public RichCompound(string chemical, float boilingPoint, float meltingPoint, double molecularWeight, string moleculerFormula) : base(chemical)
        {
            BoilingPoint = boilingPoint;
            MeltingPoint = meltingPoint;
            MolecularWeight = molecularWeight;
            MoleculerFormula = moleculerFormula;
        }

        public override string ToString()
        {

            BoilingPoint = ChemicalDatabank.MapRichCompounds[Chemical].BoilingPoint;
            MeltingPoint = ChemicalDatabank.MapRichCompounds[Chemical].MeltingPoint;
            MolecularWeight = ChemicalDatabank.MapRichCompounds[Chemical].MolecularWeight;
            MoleculerFormula = ChemicalDatabank.MapRichCompounds[Chemical].MoleculerFormula;

            return $"{base.ToString()}\n"
                      + $"\t\tFormula: {MoleculerFormula}\n"
                      + $"\t\tWeight: {MolecularWeight}\n"
                      + $"\t\tMelting Pt: {MeltingPoint}\n"
                      + $"\t\tBoiling Pt: {BoilingPoint}\n";

        }
    }
}
