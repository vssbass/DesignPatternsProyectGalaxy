namespace PrototypeContratosPattern;
public abstract class Plantilla
{
    public int TipoContrato { get; set; }
    public int TipoDocumento { get; set; }
    public string TipoDocumentoNombre { get; set; } = null!;
    public string NumeroDocumento { get; set; } = null!;
    public string NombresApellidos { get; set; } = null!;
    public string Direccion { get; set; } = null!;
    public string Telefono { get; set; } = null!;
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public string CreatedBy { get; set; } = "SYSTEM";

    public virtual string MostrarCabecera()
    {
        //EMPRESAS_CON_RUC_JURIDICO_NACIONAL
        //EMPRESAS_CON_RUC_JURIDICO_EXTRANJERO
        //EMPRESAS_CON_RUC_NATURAL_NACIONAL
        //EMPRESAS_CON_RUC_NATURAL_EXTRANJERO
        //MICRONEGOCIOS_CON_RUC_NATURAL
        return 
            $"[CONTRATO:] MOVISTAR DEL PERÚ (RUC: 2020254125874) brindará el servicio de INTERNET 1GB MBPS 100% FIBRA ÓPTICA a {NombresApellidos} identificado con {TipoDocumentoNombre}: {NumeroDocumento}, Dirección: {Direccion}, Teléfono: {Telefono}, Fecha de registro: {CreationDate:dd/MM/yyyy}, Usuario: {CreatedBy ?? "SYSTEM"}";
    }
}


