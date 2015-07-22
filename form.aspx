<%@ Page Language="C#" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="FormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>formTest</title>
  <style>
    .test {
      padding: 10px;
      margin-bottom: 5px;
    }

    input[type=submit] {
      background-color: #6d9af7;
      font-size: 24px;
      color: #FFF;
      font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div class="test">
      <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
    
    <div class="test">
      <asp:Table ID="Table1" runat="server"></asp:Table>
    </div>
    
    <div class="test">
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>

    <div class="test">
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
      <asp:ListItem Value="ListItem1">checkbox1</asp:ListItem>
      <asp:ListItem Value="ListItem2">checkbox2</asp:ListItem>
      <asp:ListItem Value="ListItem3">checkbox3</asp:ListItem>
    </asp:CheckBoxList>
    </div>

    <div class="test">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
      <asp:ListItem Value="ListItem1">radio1</asp:ListItem>
      <asp:ListItem Value="ListItem2">radio2</asp:ListItem>
      <asp:ListItem Value="ListItem3">radio3</asp:ListItem>
    </asp:RadioButtonList>
    </div>

    <div class="test">
      <asp:FileUpload ID="FileUpload1" runat="server" />
    </div>

    <div class="test">
      <input id="Submit1" type="submit" value="submit" size="20"/>
    </div>
  </form>
</body>
</html>
