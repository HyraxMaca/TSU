using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace Tsu.Website.Infrastructure
{
	public class NinjectControllerFactory : DefaultControllerFactory
	{
		private IKernel _kernel;

		public NinjectControllerFactory()
		{
			_kernel = new StandardKernel();
			AddBindings();
		}

		protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
		{
			return (controllerType == null) ? null : (IController)_kernel.Get(controllerType);
		}

		protected void AddBindings()
		{
			// Context
		}
	}
}