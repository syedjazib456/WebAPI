using System;
using System.ComponentModel.DataAnnotations;

namespace FullStackAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public double Salary { get; set; }
        public int Age {  get; set; }
    }
}
