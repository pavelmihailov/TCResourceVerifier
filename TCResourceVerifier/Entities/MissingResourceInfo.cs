#region Copyright notice

//<copyright file="MissingResourceInfo.cs" company="ISV Rouslan Grabar" datetime="2012-08-17T09:53">
//  Copyright (c) ISV Rouslan Grabar (c) 2012. All rights reserved.
//</copyright>

#endregion

namespace TCResourceVerifier.Entities
{
	public class MissingResourceInfo
	{
		/// <summary>
		/// lang key
		/// </summary>
		public string LanguageName { get; set; }

		/// <summary>
		/// file where problem is found
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Missing resource name
		/// </summary>
		public string ResourceName { get; set; }
	}
}