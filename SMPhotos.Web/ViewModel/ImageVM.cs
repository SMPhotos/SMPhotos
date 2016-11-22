﻿using SMPhotos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMPhotos.Web.ViewModel
{
	public class ImageVM
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int AlbumId { get; set; }
		public virtual Album Album { get; set; }
	}
}