﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathService1
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        Int32 Add(Int32 piNum1, Int32 piNum2);

        [OperationContract]
        Int32 Subtract(Int32 piNum1, Int32 piNum2);

        [OperationContract]
        Int32 Multiply(Int32 piNum1, Int32 piNum2);

        [FaultContract(typeof(DivideByZeroFault))]
        [OperationContract]
        Int32 Divide(Int32 piNum1, Int32 piNum2);
    }
}