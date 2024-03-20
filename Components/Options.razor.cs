using Microsoft.AspNetCore.Components;
using TaxaApp.Code;

namespace TaxaApp.Components
{
    public partial class Options
    {
        public OptionForm Form { get; set; } = new();

        [Parameter]
        public EventCallback<OptionForm> FormChange { get; set; }

        private string CarryErrorMSG(string field) => $"\"{field}\" feltet skal angive et heltal";
    }
}
