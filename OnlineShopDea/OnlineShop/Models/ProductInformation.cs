﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
	public class ProductInformation
	{
		public List<Product> Products{ get; set; }
		public int Count { get; set; }
	}
}