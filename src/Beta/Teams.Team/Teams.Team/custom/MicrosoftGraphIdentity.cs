namespace Microsoft.Graph.PowerShell.Models
{
    using static Microsoft.Graph.PowerShell.Runtime.Extensions;
    public partial interface IMicrosoftGraphIdentity :
        Microsoft.Graph.PowerShell.Runtime.IJsonSerializable
    {
        System.Collections.Generic.ICollection<string> AdditionalData { get; set; }
    }

    public partial class MicrosoftGraphIdentity :
        Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentity,
        Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityInternal
    {
        private System.Collections.Generic.ICollection<string> _additionalData;

        [Microsoft.Graph.PowerShell.Origin(Microsoft.Graph.PowerShell.PropertyOrigin.Owned)]
        public System.Collections.Generic.ICollection<string> AdditionalData { get => this._additionalData; set => this._additionalData = value; }
    }
}