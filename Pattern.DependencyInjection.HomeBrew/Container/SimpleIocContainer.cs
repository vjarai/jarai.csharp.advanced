using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Container
{
    /// <summary>
    /// Ein einfacher "Eigenbau" IoC Container (nur als "Proof of Concept")
    /// </summary>
    public class SimpleIocContainer
    {
        private readonly List<TypeRegistration> _registrations = new List<TypeRegistration>();


        public void Register<TTypeToResolve, TConcrete>(LifeCycle lifeCycle = LifeCycle.Singleton)
        {
            _registrations.Add(new TypeRegistration(typeof(TTypeToResolve), typeof(TConcrete), lifeCycle));
        }

        /// <summary>
        /// Erstellt das "Composition root Object"
        /// Erstellt rekursiv alle abhängigen Aggregate via Reflection / Constructor Injection automatisch
        /// </summary>
        /// <typeparam name="TTypeToResolve">Typ des zu erstellenden Objects</typeparam>
        /// <returns>Neue Instanz (inkl. aller abhängigen Aggregate)</returns>
        public TTypeToResolve Resolve<TTypeToResolve>()
        {
            return (TTypeToResolve)Resolve(typeof(TTypeToResolve));
        }


        private object GetInstance(TypeRegistration typeRegistration)
        {
            if (typeRegistration.Instance == null ||
                typeRegistration.LifeCycle == LifeCycle.Transient)
            {
                var parameters = ResolveConstructorParameters(typeRegistration).ToArray();
                typeRegistration.CreateInstance(parameters);

                Debug.WriteLine($"Instance of {typeRegistration.ConcreteType.Name} created.");
            }

            return typeRegistration.Instance;
        }


        private IEnumerable<object> ResolveConstructorParameters(TypeRegistration typeRegistration)
        {
            var constructorInfo = typeRegistration.ConcreteType.GetConstructors().First();
            foreach (var parameter in constructorInfo.GetParameters())
            {
                yield return Resolve(parameter.ParameterType);
            }
        }


        private object Resolve(Type typeToResolve)
        {
            var registration = _registrations.FirstOrDefault(r => r.RegisteredType == typeToResolve);

            if (registration == null)
            {
                // Auto register Type as Singleton
                registration = new TypeRegistration(typeToResolve, typeToResolve, LifeCycle.Singleton);
                _registrations.Add(registration);
            }

            return GetInstance(registration);
        }
    }
}