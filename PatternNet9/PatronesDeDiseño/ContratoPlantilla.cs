using System;

public abstract class ContratoPlantilla
{
    public int TipoContrato { get; set; }
    public int TipoDocumento { get; set; }
    public string TipoDocumentoNombre { get; set; }
    public string NumeroDocumento { get; set; }
    public string NombresApellidos { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public string CreatedBy { get; set; } = "SYSTEM";

    public virtual void MostrarCabecera()
    {
        //EMPRESAS_CON_RUC_JURIDICO_NACIONAL
        //EMPRESAS_CON_RUC_JURIDICO_EXTRANJERO
        //EMPRESAS_CON_RUC_NATURAL_NACIONAL
        //EMPRESAS_CON_RUC_NATURAL_EXTRANJERO
        //MICRONEGOCIOS_CON_RUC_NATURAL
        Console.WriteLine($"-- CONTRATO PARA {TipoContrato}--");
        Console.WriteLine($"-- LA EMPRESAS MOVISTAR DEL PERÚ IDENTIFICADA CON RUC: 2020254125874 SE COMPROMETE A BRINDAR EL SERVICIO DE INTERNET 1GB MBPS 100% FIBRA OPTICA");
        Console.WriteLine($"-- A LA PERSONA IDENTIFICADA CON {TipoDocumentoNombre} : {NumeroDocumento} --");
        Console.WriteLine($"-- NOMBRES Y APELLIDOS: {NombresApellidos} --");
        Console.WriteLine($"-- DIRECCION: {Direccion} --");
        Console.WriteLine($"-- TELEFONO: {Telefono} --");
        Console.WriteLine($"Fecha registro contrato : {CreationDate}");
        Console.WriteLine($"Usuario Registro:  {CreatedBy ?? "SYSTEM"}");
    }

}
