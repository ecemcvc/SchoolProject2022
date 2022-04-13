using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Entities
{
    public class Exam
    {
		public int Id { get; set; }
		public int CourseId { get; set; }
		public int SemesterId { get; set; }
		public int ExamTypeId { get; set; }
		public DateTime ExamDate { get; set; }
		public int Duration { get; set; }
	}
}
