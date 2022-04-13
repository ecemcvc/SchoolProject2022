using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public int DepartmentId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
