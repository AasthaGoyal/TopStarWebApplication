<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoImage.aspx.cs" Inherits="TopStarWebApplication01.DemoImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:FileUpload ID="fpLogoImage" runat="server" Height="25px" Width="269px" />
&nbsp;<asp:button id="btnUpload" type="submit" text="Upload" runat="server" Height="31px" Width="119px" OnClick="btnUpload_Click"></asp:button>
            <asp:Panel ID="frmConfirmation" Visible="False" Runat="server">
<asp:Label id="txtResult" Runat="server"/>
</asp:Panel>
        </div>
    </form>
</body>
</html>
