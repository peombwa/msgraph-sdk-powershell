namespace Microsoft.Graph.PowerShell.Models
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;
    public partial class MicrosoftGraphIdentity
    {
        
        partial void AfterFromJson(Microsoft.Graph.PowerShell.Runtime.Json.JsonObject json){
            System.Collections.Generic.ICollection<string> jsonKeys = json.Keys;
            System.Collections.Generic.IList<System.Reflection.PropertyInfo> props = this.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo item in props)
            {
                System.Console.WriteLine($"{item.Name}");
                // jsonKeys.Remove(item.Name);
            }
            { _additionalData = jsonKeys; }
        }
    }
}