#region Copyright notice

//<copyright file="WidgetFileType.cs" company="ISV Rouslan Grabar" datetime="2012-08-17T01:22">
//  Copyright (c) ISV Rouslan Grabar (c) 2012. All rights reserved.
//</copyright>

#endregion

namespace TCResourceVerifier.Entities
{
	/// <summary>
	/// dependency file types
	/// </summary>
	public enum WidgetFileType
	{
		/// <summary>
		/// xml
		/// </summary>
		WidgetDefinition,

		/// <summary>
		/// vm
		/// </summary>
		VelocityFile,

		/// <summary>
		/// js
		/// </summary>
		JavaScript,

		/// <summary>
		/// css
		/// </summary>
		StyleSheet,

		/// <summary>
		/// png, jpg, gif
		/// </summary>
		Image,

		/// <summary>
		/// anything else
		/// </summary>
		Other
	}
}