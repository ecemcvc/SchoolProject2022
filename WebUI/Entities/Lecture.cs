﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Entities
{
	public class Lecturer
	{
		public int Id { get; set; }
		public int DepartmentId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}
}
