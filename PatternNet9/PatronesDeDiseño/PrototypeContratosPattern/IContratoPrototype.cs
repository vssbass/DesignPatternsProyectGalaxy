using System;
namespace PrototypeContratosPattern;
public interface IContratoPrototype<T> where T : class
{
    T Clone();
}


