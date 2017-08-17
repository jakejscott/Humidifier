using System;
using System.Linq;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnSubConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnSub);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var fn = (FnSub)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Sub");

            if (fn.Variables != null && fn.Variables.Any())
            {
                // { "Fn::Sub" : [ String, { Var1Name: Var1Value, Var2Name: Var2Value } ] } 
                writer.WriteStartArray();
                writer.WriteToken(JsonToken.String, fn.String);
                serializer.Serialize(writer, fn.Variables);
                writer.WriteEndArray();
            }
            else
            {
                // { "Fn::Sub" : String }
                writer.WriteToken(JsonToken.String, fn.String);
            }

            writer.WriteEndObject();
        }
    }
}