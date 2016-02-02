<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AppForCloud.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="drpState" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpState_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="drpCity" runat="server"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
