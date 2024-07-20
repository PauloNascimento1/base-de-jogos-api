using System.Text.Json.Serialization;

namespace BaseDeJogos.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Genero
    {
        Ação,
        Aventura,
        Terror,
        FPS,
        Suspense,
        RPG,
        Moba,
        BattleRoyale,
        RTS,
        SoulsLike
    }
}
