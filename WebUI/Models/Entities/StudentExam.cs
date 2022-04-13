using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.Entities
{
	public class StudentsExam
	{
		public int StudentId { get; set; }
		public int ExamId { get; set; }
		public double Grade { get; set; }
	}
}
