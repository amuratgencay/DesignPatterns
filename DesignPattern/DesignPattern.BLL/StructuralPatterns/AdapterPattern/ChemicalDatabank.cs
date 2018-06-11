using System;
using System.Collections.Generic;
using DesignPattern.Entity.StructuralPatterns.AdapterPattern;

namespace DesignPattern.BLL.StructuralPatterns.AdapterPattern
{
    public class ChemicalDatabank
    {
        public RichCompound GetCompound(CompoundType compoundType)
        {
            switch (compoundType)
            {
                case CompoundType.Water:
                    return new RichCompound(CompoundType.Water.ToString(), 100.0f, 0.0f, 18.015, "H20");
                case CompoundType.Benzene:
                    return new RichCompound(CompoundType.Benzene.ToString(), 80.1f, 5.5f, 78.1134, "C6H6");
                case CompoundType.Ethanol:
                    return new RichCompound(CompoundType.Ethanol.ToString(), 78.3f, -114.1f, 46.0688, "C2H5OH");
                default:
                    throw new ArgumentOutOfRangeException(nameof(compoundType), compoundType, null);
            }
        }
        public RichCompound GetCompound(string compoundType)
        {
            try
            {
                CompoundType type;
                Enum.TryParse(compoundType, out type);
                return GetCompound(type);
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException(nameof(compoundType), compoundType, null);
            }
            
        }
    }
}
