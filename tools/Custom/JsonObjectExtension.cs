// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Models
{
    public static class JsonObjectExtension
    {
        public static bool IsJsonObjectNull(this Microsoft.Graph.PowerShell.Runtime.Json.JsonObject json) => (json is null) ? true : false;

        /// <summary>
        /// Add extra open type properties to an additional data property bag.
        /// </summary>
        /// <param name="json">The JSON response from the service.</param>
        /// <param name="entity">The OpenType entity to add an additional data property.</param>
        /// <returns>A <see cref="System.Collections.Hashtable"/></returns>
        public static System.Collections.Hashtable AddAdditionalData(this Microsoft.Graph.PowerShell.Runtime.Json.JsonObject json, object entity)
        {
            System.Collections.Generic.IList<string> jsonKeys = new System.Collections.Generic.List<string>(json.Keys);
            // Remove known properties of this type.
            foreach (System.Reflection.PropertyInfo item in entity.GetType().GetProperties())
            {
                string propertyName = System.Char.ToLowerInvariant(item.Name[0]) + item.Name.Substring(1);
                jsonKeys.Remove(propertyName);
            }

            // Add extra properties of an OData OpenType to AdditionalData property.
            System.Collections.Hashtable additionalData = new System.Collections.Hashtable(jsonKeys.Count);
            foreach (string extraProperty in jsonKeys)
            {
                { additionalData.Add(extraProperty, json.TryGetValue(extraProperty, out Microsoft.Graph.PowerShell.Runtime.Json.JsonNode __propertyValue) ? __propertyValue : null); }
            }

            return additionalData;
        }
    }
}
