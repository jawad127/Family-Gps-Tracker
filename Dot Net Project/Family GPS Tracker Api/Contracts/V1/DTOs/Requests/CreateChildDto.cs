﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family_GPS_Tracker_Api.Contracts.V1.RequestDtos
{
	public class CreateChildDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	
	}
}
