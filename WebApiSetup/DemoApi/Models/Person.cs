using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApi.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// id form SQL
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// Persons first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Persons last name
        /// </summary>
        public string LastName { get; set; } = "";
    }
}