using System;
namespace PrototypeContratosPattern;
public class ContratoServices : IContratoServices
{
    private static readonly Dictionary<int, string> TipoDocumentoMap = new()
    {
        { 1, "RUC" },
        { 2, "DNI" },
        { 3, "PASAPORTE" },
        { 4, "CARNET DE EXTRANJERIA" }
    };

    public List<string> EjecutarPatron(int TipoDocumento, string NumeroDocumento, string NombresApellidos, string Direccion, string Telefono)
    {
        var resultados = new List<string>();

        var registro = new RegistroContrato<ContratoEmpresas>();

        string TipoDocumentoNombre = TipoDocumentoMap.GetValueOrDefault(TipoDocumento, "DNI");
        //creo el objeto del primer contrato ingresado desde el front
        var primerContrato = CrearContratoPlantilla(TipoDocumento, TipoDocumentoNombre, NumeroDocumento, NombresApellidos, Direccion, Telefono);
        //registro los datos en la plantilla de contrato base 
        registro.RegistroPlantilla("EMPRESAS_CON_RUC_JURIDICO_NACIONAL", primerContrato);

        resultados.Add(primerContrato.MostrarCabecera());

        // Creamos una copia del contrato
        ContratoEmpresas? nuevoContratoAnalista = registro.CrearContrato("EMPRESAS_CON_RUC_JURIDICO_NACIONAL");
        ContratoEmpresas? nuevoContratoSupervisor = registro.CrearContrato("EMPRESAS_CON_RUC_JURIDICO_NACIONAL");
        ContratoEmpresas? nuevoContratoGerente = registro.CrearContrato("EMPRESAS_CON_RUC_JURIDICO_NACIONAL");
        //firmas q se peuden traer de la abse
        string FirmaAnalista = "FIRMA DIGITAL ANALISTA - SYSTEM CLONE";
        string FirmaSupervisor = "FIRMA DIGITAL SUPERVISOR - SYSTEM CLONE";
        string FirmaGerente = "FIRMA DIGITAL GERENCIA - SYSTEM CLONE";

        if (nuevoContratoAnalista is not null)
        {
            //ConfigurarContrato(nuevoContrato, TipoDocumento, "RUC", "20124578855", "MUNDO CAPIBARA SAC", "AV. JAVIER PRADO ESTE ORRANTIA", "987654321");
            ConfigurarContrato(nuevoContratoAnalista, TipoDocumento, TipoDocumentoNombre, NumeroDocumento, NombresApellidos, Direccion, Telefono, FirmaAnalista);
            resultados.Add(nuevoContratoAnalista.MostrarCabecera());
        }

        if (nuevoContratoSupervisor is not null)
        {
            //ConfigurarContrato(nuevoContrato, TipoDocumento, "RUC", "20124578855", "MUNDO CAPIBARA SAC", "AV. JAVIER PRADO ESTE ORRANTIA", "987654321");
            ConfigurarContrato(nuevoContratoSupervisor, TipoDocumento, TipoDocumentoNombre, NumeroDocumento, NombresApellidos, Direccion, Telefono, FirmaSupervisor);
            resultados.Add(nuevoContratoSupervisor.MostrarCabecera());
        }

        if (nuevoContratoGerente is not null)
        {
            //ConfigurarContrato(nuevoContrato, TipoDocumento, "RUC", "20124578855", "MUNDO CAPIBARA SAC", "AV. JAVIER PRADO ESTE ORRANTIA", "987654321");
            ConfigurarContrato(nuevoContratoGerente, TipoDocumento, TipoDocumentoNombre, NumeroDocumento, NombresApellidos, Direccion, Telefono, FirmaGerente);
            resultados.Add(nuevoContratoGerente.MostrarCabecera());
        }

        return resultados;
    }

    private static ContratoEmpresas CrearContratoPlantilla(int TipoDocumento, string TipoDocumentoNombre, string NumeroDocumento, string NombresApellidos, string Direccion, string Telefono)
    {
        return new ContratoEmpresas
        {
            TipoDocumento = TipoDocumento,
            TipoDocumentoNombre = TipoDocumentoNombre,
            NumeroDocumento = NumeroDocumento,
            NombresApellidos = NombresApellidos,
            Direccion = Direccion,
            Telefono = Telefono,
            CreatedBy = $"FIRMADO POR :{NombresApellidos} ",
            CreationDate = DateTime.Now
        };
    }

    private static void ConfigurarContrato(ContratoEmpresas contrato, int TipoContrato, string TipoDocumentoNombre, string NumeroDocumento, string NombresApellidos, string Direccion, string Telefono, string firmaCopia)
    {
        contrato.TipoContrato = TipoContrato;
        //contrato.TipoDocumento = 1;
        contrato.TipoDocumentoNombre = TipoDocumentoNombre;
        contrato.NumeroDocumento = NumeroDocumento;
        contrato.NombresApellidos = NombresApellidos;
        contrato.Direccion = Direccion;
        contrato.Telefono = Telefono;
        contrato.CreatedBy = firmaCopia; //"FIRMA DIGITAL AUTOMATICA - SYSTEM CLONE";
        contrato.CreationDate = DateTime.Now;
    }

}

