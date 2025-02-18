﻿using dataobjectexception.dynamics365.crud.registration.Factories;
using dataobjectexception.dynamics365.crud.registration.Infrastructure;
using dataobjectexception.dynamics365.crud.registration.Message;
using dataobjectexception.dynamics365.crud.registration.NonBinaryTree;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace dataobjectexception.dynamics365.crud.registration.Process.DeleteChildren
{
    public class ProcessingDeletePTD : FactoryDeleteChildren
    {
        //Properties
        private IServiceContainer ServiceContainer { get; }
        private Dictionary<string, Root<PluginAssembly>> ProcessingAssembly { get; }

        public ProcessingDeletePTD(IServiceContainer serviceContainer, Dictionary<string, Root<PluginAssembly>> processingAssembly)
        {
            ServiceContainer = serviceContainer;
            ProcessingAssembly = processingAssembly;
        }

        [MethodMessage("Exception in the method [ProcessRegistration] : related to : " + ConstantesProcess.ProcessingAssemblyCreateOnly)]
        public override void ProcessRegistrationDeleteChildren()
        {
            //....
        }
    }
}
