using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnBase64Converter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnBase64);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Base64" : "AWS Cloudformation" }

            var fn = (FnBase64)value;

            var valueToEncode = fn.ValueToEncode;

            if (valueToEncode is string)
            {
                var builder = new StringBuilder();
                var reader = new StringReader(valueToEncode);

                var line = reader.ReadLine();
                while (line != null)
                {
                    line = line.TrimStart(' ');
                    builder.AppendLine(line);
                    line = reader.ReadLine();
                }

                valueToEncode = builder.ToString();
            }

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Base64");
            serializer.Serialize(writer, valueToEncode);
            writer.WriteEndObject();
        }
    }
}