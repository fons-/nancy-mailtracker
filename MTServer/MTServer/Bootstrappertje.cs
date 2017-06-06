using Nancy;
using Nancy.Bootstrapper;
using Nancy.Session;
using Nancy.TinyIoc;
using System;

namespace MTServer
{
	public class Bootstrappertje : DefaultNancyBootstrapper
	{
		// The bootstrapper enables you to reconfigure the composition of the framework,
		// by overriding the various methods and properties.
		// For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

		protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
		{
			Console.WriteLine("App startup");
			base.ApplicationStartup(container, pipelines);
			//CookieBasedSessions.Enable(pipelines);
		}

		protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
		{
			Console.WriteLine("Request startup");
			base.RequestStartup(container, pipelines, context);
			//CookieBasedSessions.Enable(pipelines);
		}
	}
}