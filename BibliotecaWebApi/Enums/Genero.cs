using System.Text.Json.Serialization;

namespace BibliotecaWebApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Genero
    {
        Romance,
        Ficcao,
        Suspense,
        Cientifico,
        Biografia
    }
}
