using System;

public interface IContratoPrototype<T> where T : class
{
    T Clone();
}


