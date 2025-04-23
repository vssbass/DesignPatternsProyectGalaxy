
namespace PrototypeContratosPattern;
public class RegistroContrato<T> where T : Plantilla
{
    private Dictionary<string, IContratoPrototype<T>> _templates = new();

    public void RegistroPlantilla(string key, IContratoPrototype<T> template)
    {
        _templates[key] = template;
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

