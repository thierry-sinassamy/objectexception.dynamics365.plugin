﻿using dataobjectexception.dynamics365.cqrs.registration.Inversion;
using dataobjectexception.dynamics365.cqrs.registration.Result;
using System;

namespace dataobjectexception.dynamics365.cqrs.registration.PluginAssembly
{
    public sealed class RegisterPluginAssemblyCommandHandler : ICommandHandler<RegisterPluginAssemblyCommand>
    {
        private readonly IServiceProvider _serviceProvider;

        public RegisterPluginAssemblyCommandHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Purpose : handle the creation of the Plugin Assembly in the D365 Organization
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public ResultValidation Handle(RegisterPluginAssemblyCommand command)
        {
            //PluginAssembly.Name = command.Name, etc...
            throw new NotImplementedException();
        }
    }
}
