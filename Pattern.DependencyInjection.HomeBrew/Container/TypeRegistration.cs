using System;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Container
{
    public class TypeRegistration
    {
        public TypeRegistration(Type registeredType, Type concreteType, LifeCycle lifeCycle)
        {
            RegisteredType = registeredType;
            ConcreteType = concreteType;
            LifeCycle = lifeCycle;
        }

        public Type ConcreteType { get; set; }

        public object Instance { get; set; }
        public LifeCycle LifeCycle { get; set; }
        public Type RegisteredType { get; set; }

        public object CreateInstance(object[] args)
        {
            Instance = Activator.CreateInstance(ConcreteType, args);
            return Instance;
        }
    }
}