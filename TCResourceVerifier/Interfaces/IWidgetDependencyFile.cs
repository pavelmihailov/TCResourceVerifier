#region Copyright notice

//<copyright file="Class1.cs" company="ISV Rouslan Grabar" datetime="2012-08-17T01:22">
//  Copyright (c) ISV Rouslan Grabar (c) 2012. All rights reserved.
//</copyright>

#endregion

using TCResourceVerifier.Entities;

namespace TCResourceVerifier.Interfaces
{
	public interface IWidgetDependencyFile : IWidgetFile
	{
		string FullPath { get; set; }
		WidgetFileType WidgetFileType { get; set; }
	}
}
