using System.ServiceModel;
using DesignPattern.WebApp.Entity;

namespace DesignPattern.WebApp.Interfaces
{
    [ServiceContract]
    public interface IBllFactoryPattern : IBll
    {
        [OperationContract]
        VmShapeTypes GetShapeTypes();

        [OperationContract]
        string GetShape(int shapeType);
    }
}