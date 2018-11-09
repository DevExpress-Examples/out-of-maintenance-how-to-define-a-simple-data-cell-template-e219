<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CellTemplates._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <dxwtl:TreeListDataColumn FieldName="Name" VisibleIndex="0">
                </dxwtl:TreeListDataColumn>
                <dxwtl:TreeListDataColumn Caption="Temp1" Name="colTemp1" VisibleIndex="1">
                </dxwtl:TreeListDataColumn>
                <dxwtl:TreeListDataColumn Caption="Temp2" Name="colTemp2" VisibleIndex="2">
                    <DataCellTemplate>
                        <a href="javascript:alert('Node key: <%# Container.NodeKey %>');">Click!</a>
                    </DataCellTemplate>
                </dxwtl:TreeListDataColumn>
            </Columns>
        </dxwtl:ASPxTreeList>
        &nbsp;
    </div>
    </form>
</body>
</html>
