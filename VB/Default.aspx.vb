Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxTreeList

Namespace CellTemplates
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			For i As Integer = 1 To 5
				Dim node As TreeListNode = ASPxTreeList1.AppendNode(i)
				node.SetValue("Name", String.Format("Node {0}", i))
			Next i
			CType(ASPxTreeList1.Columns("colTemp1"), TreeListDataColumn).DataCellTemplate = New CellLinkTemplate()
		End Sub
	End Class

	Friend Class CellLinkTemplate
		Implements ITemplate

		#Region "ITemplate Members"

		Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
			Dim cellContainer As TreeListDataCellTemplateContainer = CType(container, TreeListDataCellTemplateContainer)
			Dim link As HyperLink = New HyperLink()
			link.Text = "Click!"
			link.NavigateUrl = String.Format("javascript:alert('Node key: {0}');", cellContainer.NodeKey)
			container.Controls.Add(link)
		End Sub

		#End Region
	End Class
End Namespace
