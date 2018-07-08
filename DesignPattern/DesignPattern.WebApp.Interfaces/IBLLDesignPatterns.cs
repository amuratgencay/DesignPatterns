using System.ServiceModel;
using DesignPattern.WebApp.Entity;

namespace DesignPattern.WebApp.Interfaces
{
    [ServiceContract]
    public interface IBll
    {
        
    }

    [ServiceContract]
    public interface IBllDesignPatterns : IBll
    {
        [OperationContract]
        VmCreationalDesignPatterns GetCreationalDesignPatterns();

        [OperationContract]
        VmStructuralDesignPatterns GetStructuralDesignPatterns();

        [OperationContract]
        VmBehavioralDesignPatterns GetBehavioralDesignPatterns();

        [OperationContract]
        VmDesignPatterns GetDesignPatterns();
    }
}