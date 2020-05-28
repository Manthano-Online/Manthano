using System;
using System.Collections.Generic;
using Manthano.Common.ActionHandlers.Base;
using Manthano.Common.Actions.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Manthano.Common
{
    internal class ActionHandlerRegistration
    {
        private readonly Dictionary<string, Type> _items;

        internal ActionHandlerRegistration()
        {
            _items = new Dictionary<string, Type>();
        }

        internal AbstractActionHandler Find(AbstractAction action, IServiceProvider serviceProvider)
        {
            _items.TryGetValue(action.Name, out var result);
            return (AbstractActionHandler)ActivatorUtilities.CreateInstance(serviceProvider, result);
        }

        internal void Register(AbstractActionHandler handler)
        {
            _items.Add(handler.ActionName, handler.GetType());
        }

        internal void Unregister(AbstractActionHandler handler)
        {
            _items.Remove(handler.ActionName);
        }
    }
}
