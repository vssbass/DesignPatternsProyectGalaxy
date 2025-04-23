using System;

public class ContratoServices : IContratoServices
{
    public void EjecutarPatron()
    {
        var registro = new RegistroContrato<ContratoPlantilla>();

        var primerContrato = new ContratoPlantilla()
        {
            TipoContrato = 1, //1 contrato empresas 2 contrato personas
            TipoDocumento = 1, //1 ruc 2 dni 3 pasaporte 4 carnet de extranjeria
            TipoDocumentoNombre = "RUC",
            NumeroDocumento = "20124578855",
            NombresApellidos = "MI PEQUEÑA EMPRESAS SAC",
            Direccion = "AV. JAVIER PRADO ESTE ORRANTIA",
            Telefono = "987654321"

        };

        registro.RegisterTemplate("EMPRESAS_CON_RUC_JURIDICO_NACIONAL", primerContrato);

        primerContrato.MostrarCabecera();

        Console.WriteLine("Creando un nuevo contrato");

        ContratoPlantilla? nuevoContrato = registro.CrearContrato("EMPRESAS_CON_RUC_JURIDICO_NACIONAL");

        if (nuevoContrato is not null)
        {
            nuevoContrato.TipoContrato = 1;
            nuevoContrato.TipoDocumento = 1;
            nuevoContrato.TipoDocumentoNombre = "RUC";
            nuevoContrato.NumeroDocumento = "20124578855";
            nuevoContrato.NombresApellidos = "MUNDO CAPIBARA SAC";
            nuevoContrato.Direccion = "AV. JAVIER PRADO ESTE ORRANTIA";
            nuevoContrato.Telefono = "987654321";


            nuevoContrato.MostrarCabecera();
        }

        Console.WriteLine("La plantilla no tiene porque cambiar");
        primerContrato.MostrarCabecera();
    }
}
