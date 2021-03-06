﻿using Autofac;
using Autofac.Integration.Mvc;
using Cubit.Controllers;
using Cubit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Cubit.App_Start
{
    public class ContainerConfig
    {
        public static void RegisterTypes()
        {
            return;

            // Reserved for dependency type registry
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}