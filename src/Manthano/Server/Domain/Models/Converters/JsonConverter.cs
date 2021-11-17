using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Manthano.Domain.Models.Converters;

public static class JsonConverter
{
    private static JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
    public static PropertyBuilder<T> HasJsonConversion<T>(this PropertyBuilder<T> propertyBuilder) where T : class, new()
    {
        ValueConverter<T, string> converter = new ValueConverter<T, string>
        (
            v => JsonSerializer.Serialize(v, jsonOptions),
            v => JsonSerializer.Deserialize<T>(v, jsonOptions) ?? new T()
        );

        ValueComparer<T> comparer = new ValueComparer<T>
        (
            (l, r) => JsonSerializer.Serialize(l, jsonOptions) == JsonSerializer.Serialize(r, jsonOptions),
            v => v == null ? 0 : JsonSerializer.Serialize(v, jsonOptions).GetHashCode(),
            v => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(v, jsonOptions), jsonOptions)
        );

        propertyBuilder.HasConversion(converter);
        propertyBuilder.Metadata.SetValueConverter(converter);
        propertyBuilder.Metadata.SetValueComparer(comparer);
        propertyBuilder.HasColumnType("text");

        return propertyBuilder;
    }
}
