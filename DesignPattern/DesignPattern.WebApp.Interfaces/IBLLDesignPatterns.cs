using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.WebApp.Entity;

namespace DesignPattern.WebApp.Interfaces
{
    [ServiceContract]
    public interface IBLL
    {

    }

    [ServiceContract]
    public interface IBLLDesignPatterns : IBLL
    {
        [OperationContract]
        vmCreationalDesignPatterns GetCreationalDesignPatterns();
        [OperationContract]
        vmStructuralDesignPatterns GetStructuralDesignPatterns();
        [OperationContract]
        vmBehavioralDesignPatterns GetBehavioralDesignPatterns();
        [OperationContract]
        vmDesignPatterns GetDesignPatterns();
    }
}
