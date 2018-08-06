using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeRequestObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://MyCompany.com/Employee", ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://MyCompany.com/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://MyCompany.com/Employee")]
    public class EmployeeInfo : IExtensibleDataObject
    {
        public EmployeeInfo()
        {

        }
        public EmployeeInfo(EmployeeModel employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth;
            this.Type = employee.Type;
            if (this.Type == EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployeeModel)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployeeModel)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployeeModel)employee).HoursWorked;
            }
            this.City = employee.City;
        }

        [MessageBodyMember(Order = 1, Namespace = "http://MyCompany.com/Employee")]
        public int Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://MyCompany.com/Employee")]
        public string Name { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://MyCompany.com/Employee")]
        public string Gender { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://MyCompany.com/Employee")]
        public DateTime DOB { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://MyCompany.com/Employee")]
        public EmployeeType Type { get; set; }
        [MessageBodyMember(Order = 6, Namespace = "http://MyCompany.com/Employee")]
        public int AnnualSalary { get; set; }
        [MessageBodyMember(Order = 7, Namespace = "http://MyCompany.com/Employee")]
        public int HourlyPay { get; set; }
        [MessageBodyMember(Order = 8, Namespace = "http://MyCompany.com/Employee")]
        public int HoursWorked { get; set; }
        [MessageBodyMember(Order = 9, Namespace = "http://MyCompany.com/Employee")]
        public string City { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }

    }


    // By default all public members are serialized
    // [Serializable] // Serializes everything
    [DataContract] // Select what you want to be serialized by decorating with [DataMember] private or public

    [KnownType(typeof(FullTimeEmployeeModel))]
    [KnownType(typeof(PartTimeEmployeeModel))]

    public class EmployeeModel : IExtensibleDataObject
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateOfBirth;

        [DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember(Order = 3)]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        [DataMember(Name="DOB", Order = 4)]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }


        //Added after - no chnages to client IsRequired will fail, not required will not break
        //[DataMember(Order = 6, IsRequired = true)]
        [DataMember(Order = 6)]
        public string City { get; set; }

        // unknown data will be stored here
        public ExtensionDataObject ExtensionData { get; set; }
    
    }

    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
