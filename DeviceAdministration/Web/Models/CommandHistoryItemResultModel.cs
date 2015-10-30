
namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Web.Models
{
    /// <summary>
    /// A model that represents a Result field item in the Command History table.
    /// </summary>
    public class CommandHistoryItemResultModel
    {
        /// <summary>
        /// Gets or sets the CSS class name that should be used with the 
        /// respresented Result field item.
        /// </summary>
        public string CssClass
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the represented Result field item's error message.
        /// </summary>
        public string ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the represented Ruesult field item's localized text.
        /// </summary>
        public string Text
        {
            get;
            set;
        }
    }
}