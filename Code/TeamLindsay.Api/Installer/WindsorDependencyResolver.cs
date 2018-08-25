using Castle.MicroKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel.Lifestyle;

namespace TeamLindsay.Api.Installer
{
    internal class WindsorDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public WindsorDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new DependencyScope(_kernel);
        }

        public object GetService(Type type)
        {
            return _kernel.HasComponent(type) ? _kernel.Resolve(type) : null;
        }

        public IEnumerable<object> GetServices(Type type)
        {
            return _kernel.ResolveAll(type).Cast<object>();
        }

        public void Dispose()
        {
        }
    }


    internal class DependencyScope : IDependencyScope
    {
        private readonly IKernel _kernel;
        private readonly IDisposable _disposable;

        internal DependencyScope(IKernel kernel)
        {
            _kernel = kernel;
            _disposable = kernel.BeginScope();
        }

        public object GetService(Type type)
        {
            return _kernel.HasComponent(type) ? _kernel.Resolve(type) : null;
        }

        public IEnumerable<object> GetServices(Type type)
        {
            return _kernel.ResolveAll(type).Cast<object>();
        }

        public void Dispose()
        {
            _disposable.Dispose();
        }
    }
}