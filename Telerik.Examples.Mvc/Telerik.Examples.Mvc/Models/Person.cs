﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Telerik.Examples.Mvc.Models
{
	public class Person
	{
		[Editable(false)]
		public int PersonID { get; set; }
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Country { get; set; }

        public bool IsAdmin { get; set; }
		public int? EyeColorIndex { get; set; }
        public Role Role { get; set; }
    }
}