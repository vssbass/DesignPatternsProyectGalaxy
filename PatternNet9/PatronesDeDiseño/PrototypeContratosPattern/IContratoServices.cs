using System;
namespace PrototypeContratosPattern;
public interface IContratoServices
{
    List<string> EjecutarPatron(int TipoDocumento, string NumeroDocumento, string NombresApellidos, string Direccion, string Telefono);
}
