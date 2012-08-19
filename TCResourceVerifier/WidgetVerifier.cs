#region Copyright notice

//<copyright file="WidgetVerifier.cs" company="ISV Rouslan Grabar" datetime="2012-08-17T08:35">
//  Copyright (c) ISV Rouslan Grabar (c) 2012. All rights reserved.
//</copyright>

#endregion

using System.Collections.Generic;
using System.IO;
using System.Linq;
using TCResourceVerifier.Entities;
using TCResourceVerifier.Interfaces;

namespace TCResourceVerifier
{
	public class WidgetVerifier
	{
		public Dictionary<IWidgetFile, Dictionary<string, MissingResourceInfo>> VerifyWidgets(string path)
		{
			var problems = new Dictionary<IWidgetFile, Dictionary<string, MissingResourceInfo>>();
			var widgetReader = new WidgetReader(path);
			List<IWidget> widgets = widgetReader.LoadWidgets();

			foreach (IWidget widget in widgets)
			{
				IEnumerable<string> tokens = LanguageTokenParser.Parse(widget.ContentScript);
				ParseContentScript(problems, widget, widget, tokens);
				foreach (
					IWidgetDependencyFile dependencyFile in
						widget.DependencyFiles.Where((df) => df.WidgetFileType == WidgetFileType.VelocityFile))
				{
					string vmFile = File.ReadAllText(dependencyFile.FullPath);
					IEnumerable<string> dependencyTokens = LanguageTokenParser.Parse(vmFile);
					ParseContentScript(problems, widget, dependencyFile, dependencyTokens);
				}
			}
			return problems;
		}

		private static void ParseContentScript(Dictionary<IWidgetFile, Dictionary<string, MissingResourceInfo>> problems,
		                                       IWidget parent,
		                                       IWidgetFile widget,
		                                       IEnumerable<string> tokens)
		{
			foreach (string token in tokens)
			{
				foreach (string languageName in parent.Languages.Keys)
				{
					if (parent.Languages[languageName].Keys.Contains(token) == false)
					{
						if (!problems.ContainsKey(parent))
						{
							problems.Add(parent, new Dictionary<string, MissingResourceInfo>());
						}
						problems[parent][languageName] = new MissingResourceInfo
							{
								FileName = widget.FileName,
								LanguageName = languageName,
								ResourceName = token
							};
					}
				}
			}
		}
	}
}