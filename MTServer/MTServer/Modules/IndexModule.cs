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
				TrackEntry trackEntry = new TrackEntry(parameters.tag, Request.UserHostAddress, DateTime.Now);
				Console.WriteLine(trackEntry);

				return Response.AsImage("Content/nancy-logo.png");
			};
			//Get["/{whatever*}"] = _ => Response.AsRedirect("/");
		}
	}
}