using TaxaApp.Code;

namespace TaxaApp.Pages
{
    public partial class Index
    {
        public OptionForm Option { get; set; } = new();

        private void UpdateOptionForm(OptionForm update) => Option = update;

    }
}
