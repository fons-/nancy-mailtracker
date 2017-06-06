using Nancy;
using System;

namespace MTServer.Modules
{
	public class IndexModule : NancyModule
	{
		public IndexModule()
		{
			Get["/"] = parameters =>
			{
				return View["index"];
			};
			Get["/i/{tag}"] = parameters =>
			{
				Console.WriteLine(parameters.tag.ToString());

				return Response.AsImage("Content/nancy-logo.png");
			};
			//Get["/{whatever*}"] = _ => Response.AsRedirect("/");
		}
	}
}