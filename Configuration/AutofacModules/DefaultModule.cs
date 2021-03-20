using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Configuration.AutofacModules
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Repo.BranchRepository>().As<Repo.IBranchRepository>().SingleInstance();
        }
    }
}
