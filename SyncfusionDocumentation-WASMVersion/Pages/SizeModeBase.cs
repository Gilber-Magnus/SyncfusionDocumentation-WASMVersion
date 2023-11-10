using Microsoft.AspNetCore.Components;

namespace SyncfusionDocumentation_WASMVersion.Pages
{
    public class SizeModeBase : ComponentBase
    {
        protected bool isChecked = true;
        protected DateTime? DateValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 8);
        public string CssClass { get; set; } = null;

        protected void Touch()
        {
            CssClass = "e-bigger";
        }

        protected void Mouse()
        {
            CssClass = null;
        }
    }

}
