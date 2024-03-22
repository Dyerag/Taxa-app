using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TaxaApp.Code;

namespace TaxaApp.Components
{
    public partial class Options
    {
        public OptionForm Form { get; set; } = new();

        [Parameter]
        public EventCallback<OptionForm> FormChange { get; set; }

        private string NumberFieldsEmpty(string field) => $"{field} skal indholde et heltal";

    }
}
