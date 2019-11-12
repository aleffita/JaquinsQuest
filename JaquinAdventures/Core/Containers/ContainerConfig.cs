﻿using Autofac;
using JaquinAdventures.Components;
using JaquinAdventures.Entities;
using JaquinAdventures.Interfaces;
using JaquinAdventures.Scenes;
using Otter;
using Movement = JaquinAdventures.Components.Movement;

namespace JaquinAdventures.Core.Containers
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<GameManager>().As<IApplication>();
            
            builder.RegisterInstance(new Game("Jaquin Adventures", 1280, 720,120)
                {Color = Color.Cyan}).SingleInstance();
            builder.RegisterInstance(Game.Instance.Input);
            
            builder.RegisterType<MainScene>();
            builder.RegisterType<Player>();
            builder.RegisterType<WasdInput>().As<IInputHandler>();
            
            builder.RegisterType<MovementWithSprint>().As<IMovement>();
            
            return builder.Build();
        }
    }
}