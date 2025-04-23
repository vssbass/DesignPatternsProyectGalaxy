using System;

public class RegistroContrato<T> : where T : ContratoPlantilla
{
    private Dictionary<string, IContratoPrototype<T>> _contratos = new();

    public void RegistroContrato(string key, IContratoPrototype<T> template)
    {
        _contratos[key] = template;
    }

    public T? CrearContrato(string key)
    {
        if (_templates.TryGetValue(key, out var template))
        {
            return template.Clone() as T;
        }

        return null;
    }
}

