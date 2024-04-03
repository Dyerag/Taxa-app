using Microsoft.AspNetCore.Components;
using TaxaApp.Code;

namespace TaxaApp.Components
{
    public partial class Result
    {
        public DisplayValues ResultDisplay { get; set; } = new();

        private OptionForm _inputForm;
        [Parameter]
        public OptionForm InputForm
        {
            get
            {
                return _inputForm;
            }
            set
            {
                _inputForm = value;
                ResultDisplay.GetValues(InputForm);
            }
        }
    }
}
