using Castle.Windsor;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace TeamLindsay.Api.Controllers
{
    public class WebApiControllerFactory : IHttpControllerActivator
    {
        private readonly IWindsorContainer _container;

        public WebApiControllerFactory(IWindsorContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            try
            {
                var controller = (IHttpController)_container.Resolve(controllerType);
                request.RegisterForDispose(new Release(() => _container.Release(controller)));

                return controller;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private class Release : IDisposable
        {
            private readonly Action _release;

            public Release(Action release)
            {
                _release = release;
            }

            public void Dispose()
            {
                _release();
            }
        }
    }
}