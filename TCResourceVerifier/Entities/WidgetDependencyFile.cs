#region Copyright notice

//<copyright file="WidgetDependencyFile.cs" company="ISV Rouslan Grabar" datetime="2012-08-17T09:35">
//  Copyright (c) ISV Rouslan Grabar (c) 2012. All rights reserved.
//</copyright>

#endregion

using TCResourceVerifier.Interfaces;

namespace TCResourceVerifier.Entities
{
	public class WidgetDependencyFile : IWidgetDependencyFile
	{
		#region Implementation of IWidgetDependencyFile

		public string FullPath { get; set; }
		public string FileName { get; set; }
		public WidgetFileType WidgetFileType { get; set; }
		public IWidgetFile Parent { get; set; }

		#endregion
	}
}