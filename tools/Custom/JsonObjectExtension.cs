// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using Microsoft.Graph.PowerShell.Runtime;
using System.Linq;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Models
{
    public static class JsonObjectExtension
    {
        public static bool IsJsonObjectNull(this Runtime.Json.JsonObject json) => (json is null) ? true : false;

        /// <summary>
        /// Add extra open type properties to an additional data property bag.
        /// </summary>
        /// <param name="json">The JSON response from the service.</param>
        /// <param name="entityType">The OpenType entity to add an additional data property.</param>
        /// <returns>A <see cref="System.Collections.Hashtable"/></returns>
        public static System.Collections.Hashtable AddAdditionalData(this Runtime.Json.JsonObject json, System.Type entityType)
        {
            System.Collections.Generic.IList<string> dynamicKeys = new System.Collections.Generic.List<string>(json.Keys);
            // Remove known properties of this type from jsonKeys.
            foreach (PropertyInfo item in entityType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                if (item.GetCustomAttribute(typeof(OriginAttribute)) is OriginAttribute attribute && attribute.Origin != PropertyOrigin.Inlined)
                {
                    string serializedName = char.ToLowerInvariant(item.Name[0]) + item.Name.Substring(1);
                    dynamicKeys.Remove(serializedName);
                }
            }

            // Add extra properties of an OData OpenType to AdditionalData property.
            System.Collections.Hashtable additionalData = new System.Collections.Hashtable(dynamicKeys.Count);
            foreach (string dynamicKey in dynamicKeys)
            {
                if (json.TryGetValue(dynamicKey, out Runtime.Json.JsonNode __dynamicValue) && __dynamicValue != "null")
                {
                    additionalData.Add(char.ToUpperInvariant(dynamicKey[0]) + dynamicKey.Substring(1), __dynamicValue);
                }
            }

            return additionalData;
        }
    }
}
