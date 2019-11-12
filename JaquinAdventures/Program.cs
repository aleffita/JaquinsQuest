﻿using System;
using Autofac;
using Autofac.Core;
using Otter;

namespace JaquinAdventures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}