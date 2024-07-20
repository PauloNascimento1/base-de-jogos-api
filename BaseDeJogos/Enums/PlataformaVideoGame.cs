using System.Text.Json.Serialization;

namespace BaseDeJogos.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlataformaVideoGame
    {
        Xbox,
        Playstation,
        PC,
        Switch
    }
}
