using System.Text.Json.Serialization;

namespace BaseDeJogos.Enums
{
   [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusJogo
    {
        Interessado,
        Pendente,
        EmAndamento,
        Finalizado,
        Platinado,
        Online

    }
}
