using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        EmployeeInfo GetEmployee(EmployeeRequest request); //message contract

        [OperationContract]
        void SaveEmployee(EmployeeInfo Employee); //message contract
    }
}
