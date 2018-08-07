using System;
using System.ServiceModel;

namespace MathService1
{
    [GlobalErrorHandlerBehaviour(typeof(GlobalErrorHandler))]
    public class MathService : IMathService
    {
        
        public Int32 Add(Int32 piNum1, Int32 piNum2)
        {
            return piNum1 + piNum2;
        }


        public Int32 Subtract(Int32 piNum1, Int32 piNum2)
        {
            return piNum1 - piNum2;
        }


        public Int32 Multiply(Int32 piNum1, Int32 piNum2)
        {
            return piNum1 * piNum2;
        }


        public Int32 Divide(Int32 piNum1, Int32 piNum2)
        {
            //if (piNum2 == 0)
            //    throw new FaultException("Denominator cannot be ZERO", new FaultCode("DivideByZeroFault"));
            //return piNum1 / piNum2;

            //try
            //{
                return piNum1 / piNum2;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    DivideByZeroFault divideByZeroFault = new DivideByZeroFault();
            //    divideByZeroFault.Error = ex.Message;
            //    divideByZeroFault.Details = "Denominator cannot be ZERO";
            //
            //    throw new FaultException<DivideByZeroFault>(divideByZeroFault);
            //}
        }

       
    }
}
