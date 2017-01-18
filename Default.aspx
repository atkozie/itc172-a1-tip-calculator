<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet.css">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>tip calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Tip Calculator</h1>
    <div class="content">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Meal Amount"></asp:Label>
            <!--renamed because will refer to textbox in code-->
            <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="TipPercentsRadioButtonList" runat="server"></asp:RadioButtonList>
            <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" Height="26px" OnClick="SubmitButton_Click" />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
