using System;
namespace PrototypeContratosPattern;
public class ContratoEmpresas : Plantilla, IContratoPrototype<ContratoEmpresas>
{

    public ContratoEmpresas()
    {
        TipoContrato = 1;
        TipoDocumento = 1;
        TipoDocumentoNombre = "RUC";
        NumeroDocumento = "10462095061";
        NombresApellidos = "VICTOR SANTOS";
        Direccion = "CL. LOS PORTALES";
        Telefono = "945356861";
    }

    public ContratoEmpresas Clone()
    {
        var clonedContrato = (ContratoEmpresas)this.MemberwiseClone();
        clonedContrato.CreationDate = DateTime.Now;
        clonedContrato.CreatedBy = "SYSTEM";

        var clonado = new ContratoEmpresas()
        {
            TipoContrato = TipoContrato,
            TipoDocumento = TipoDocumento,
            TipoDocumentoNombre = TipoDocumentoNombre,
            NumeroDocumento = NumeroDocumento,
            NombresApellidos = NombresApellidos,
            Direccion = Direccion,
            Telefono = Telefono
        };

        return clonedContrato;
    }

    public override string MostrarCabecera()
    {

        return base.MostrarCabecera();
    }
}

