<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportView.aspx.cs" Inherits="MvcApplication8.Reports.ReportView" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 464px;
        }
    </style>
</head>
<body style="height: 478px">
    <form id="form1" runat="server">
    <div style="height: 136px">
    
    <asp:Button value="Preview" Text="Preview"  runat="server" ID="Preview" ValidationGroup="view" type="submit"   OnClick="Preview_Click" /> 
   
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="322px">
            <CR:CrystalReportPartsViewer ID="CrystalReportPartsViewer1" runat="server" AutoDataBind="true"  Height="150px"  
    Width="350px" ToolPanelView="None" ReportSourceID="CrystalReportSource1"   />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                <Report FileName="Reports\CrystalReport1.rpt">
                </Report>
            </CR:CrystalReportSource>
        </asp:Panel>
    </form>
</body>
</html>
