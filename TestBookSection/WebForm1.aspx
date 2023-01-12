<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestBookSection.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server"  />
                        <asp:Button ID="BtnOpen" runat="server" Text="OpenFile" OnClick="BtnOpen_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                      <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" Height="150px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="">PageIndex</asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="">PageSize</asp:Label></td>
                
                    <td>
                            <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnView" runat="server" Text="View" OnClick="BtnView_Click" /></td>
                </tr>
            </table>
          
        </div>
    </form>
</body>
</html>
