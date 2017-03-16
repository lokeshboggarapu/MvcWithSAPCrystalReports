<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportView2.aspx.cs" Inherits="MvcApplication8.Reports.ReportView2" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <CR:CrystalReportViewer ID="CrystalReportViewer2" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CrystalReportSource2" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
                        <CR:CrystalReportSource ID="CrystalReportSource2" runat="server">
                            <report filename="CrystalReport2.rpt">
                            </report>
                        </CR:CrystalReportSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
