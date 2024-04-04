using Microsoft.AspNetCore.Components;
using TaxaApp.Code;

namespace TaxaApp.Components
{
    public partial class Result
    {
        DisplayValues resultDisplay = new();
        double taxiCost = 0;

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
                resultDisplay.GetValues(InputForm);
            }
        }
    }
}
