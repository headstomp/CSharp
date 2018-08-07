using System.Runtime.Serialization;

namespace MathService1
{
    [DataContract]
    public class DivideByZeroFault
    {
        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public string Details { get; set; }
    }
}