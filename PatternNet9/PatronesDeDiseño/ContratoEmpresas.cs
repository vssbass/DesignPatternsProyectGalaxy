using System;

public class ContratoEmpresas : ContratoPlantilla, IContratoPrototype<ContratoEmpresas>
{
    public readonly ContratoPlantilla _contratoPlantilla;

    public ContratoEmpresas(ContratoPlantilla contratoPlantilla)
    {
        _contratoPlantilla.TipoContrato = contratoPlantilla.TipoContrato;
        _contratoPlantilla.TipoDocumento = contratoPlantilla.TipoDocumento;
        _contratoPlantilla.TipoDocumentoNombre = contratoPlantilla.TipoDocumentoNombre;
        _contratoPlantilla.NumeroDocumento = contratoPlantilla.NumeroDocumento;
        _contratoPlantilla.NombresApellidos = contratoPlantilla.NombresApellidos;
        _contratoPlantilla.Direccion = contratoPlantilla.Direccion;
        _contratoPlantilla.Telefono = contratoPlantilla.Telefono;
        _contratoPlantilla.CreationDate = DateTime.Now;
        _contratoPlantilla.CreatedBy = contratoPlantilla.CreatedBy;

        //TipoContrato = 1;
        //TipoDocumento = 1;
        //TipoDocumentoNombre = "RUC";
        //NumeroDocumento = "2020254125874";
        //NombresApellidos = "EMPRESA MOVISTAR DEL PERU";
        //Direccion = "AV. JAVIER PRADO ESTE 1234";
        //Telefono = "987654321";

    }

    public ContratoEmpresas Clone()
    {
        var clonedContrato = (ContratoEmpresas)this.MemberwiseClone();
        clonedContrato.CreationDate = DateTime.Now;
        clonedContrato.CreatedBy = null;
        return clonedContrato;
    }

    public override void MostrarCabecera()
    {
        base.MostrarCabecera();
        Console.WriteLine($"-- EMPRESAS CON RUC JURIDICO NACIONAL --");
        Console.WriteLine($"-- EMPRESAS CON RUC JURIDICO EXTRANJERO --");
        Console.WriteLine($"-- EMPRESAS CON RUC NATURAL NACIONAL --");
        Console.WriteLine($"-- EMPRESAS CON RUC NATURAL EXTRANJERO --");
        Console.WriteLine($"-- MICRONEGOCIOS CON RUC NATURAL --");
        Console.WriteLine($"Fecha registro contrato : {CreationDate}");
        Console.WriteLine($"Usuario Registro:  {CreatedBy ?? "SYSTEM"}");
    }



    public ContratoEmpresas Clone()
    {
        return (ContratoEmpresas)this.MemberwiseClone();
    }
}

