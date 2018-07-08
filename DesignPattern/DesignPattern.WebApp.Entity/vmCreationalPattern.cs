using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.WebApp.Entity
{
    [Serializable]
    public class VmShapeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    public class VmShapeTypes
    {
        public List<VmShapeType> ShapeTypes { get; set; }
    }

    [Serializable]
    public class VmFactoryPattern
    {

    }
}
