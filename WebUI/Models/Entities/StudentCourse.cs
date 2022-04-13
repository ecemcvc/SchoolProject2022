using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
	public class StudentCourse
	{
		public int StudentId { get; set; }
		public int CourseId { get; set; }
		public int SemesterId { get; set; }
	}
}
