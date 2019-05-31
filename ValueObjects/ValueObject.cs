using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace ValueObjects
{
    public abstract class ValueObject
    {

        static JsonSerializerSettings serializerSettings = BuildSerializerSettings();

        private static JsonSerializerSettings BuildSerializerSettings()
        {
            var contractResolver = new NonPublicContractResolver();
            return new JsonSerializerSettings
            {
                ContractResolver = contractResolver
            };
        }

        private string valueString;
        [JsonIgnore]
        protected string ValueString
        {
            get
            {
                if(valueString == null)
                {
                    valueString = JsonConvert.SerializeObject(this);
                }
                return valueString;
            }
            set {
                valueString = value;
                JsonConvert.PopulateObject(value, this, serializerSettings);
            }
        }

        protected ValueObject()
        {

        }
    }
}
