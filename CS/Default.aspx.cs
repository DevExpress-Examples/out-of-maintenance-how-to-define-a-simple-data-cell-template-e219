using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxTreeList;

namespace CellTemplates {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            for(int i = 1; i <= 5; i++) {
                TreeListNode node = ASPxTreeList1.AppendNode(i);
                node.SetValue("Name", String.Format("Node {0}", i));
            }
            ((TreeListDataColumn)ASPxTreeList1.Columns["colTemp1"]).DataCellTemplate = new CellLinkTemplate();
        }
    }

    class CellLinkTemplate : ITemplate {

        #region ITemplate Members

        public void InstantiateIn(Control container) {
            TreeListDataCellTemplateContainer cellContainer = (TreeListDataCellTemplateContainer)container;
            HyperLink link = new HyperLink();
            link.Text = "Click!";
            link.NavigateUrl = string.Format("javascript:alert('Node key: {0}');", cellContainer.NodeKey);
            container.Controls.Add(link);
        }

        #endregion
    }
}
