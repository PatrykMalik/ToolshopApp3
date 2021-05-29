using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolshopApp3.ViewModel;

namespace ToolshopApp3.WpfClient
{
    public class ViewModelLocator
    {
        private readonly IContainer container;
        public ViewModelLocator()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(typeof(BaseViewModel).Assembly)
                .Where(t => t.IsSubclassOf(typeof(BaseViewModel)));
            container = containerBuilder.Build();
        }
        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
         
        public CallendarViewModel CallendarViewModel => container.Resolve<CallendarViewModel>();
        public AllTasksViewModel AllTasksViewModel => container.Resolve<AllTasksViewModel>();
    }
}
