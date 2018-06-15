using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NuGetGallery {
    public partial class UrlField : System.Web.DynamicData.FieldTemplateUserControl {
        protected override void OnDataBinding(EventArgs e) {
            HyperLinkUrl.NavigateUrl = ProcessUrl(FieldValueString);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private string ProcessUrl(string url) {
            if (url.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {
                url = "https://" + url.Substring("http://".Length);
            }

            if (url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || url.StartsWith("https://", StringComparison.OrdinalIgnoreCase)) {
                return url;    
            }
    
            return "https://" + url;
        }
    
        public override Control DataControl {
            get {
                return HyperLinkUrl;
            }
        }
    
    }
}
