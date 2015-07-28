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

    .output {
      width: 400px;
      height: 180px;
      border: solid 3px #FFF;
      background-color: #000;
      color: #FFF;
    }

    input[type=submit] {
      background-color: #6d9af7;
      font-size: 24px;
      color: #FFF;
      font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    }

    .area {
      width: 200px;
      height: 100px;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div class="test">
      <input type="text" name="textbox" ></input>
    </div>

    <div class="test">
      <textarea name="area" class="area"></textarea>
    </div>

    <div class="test">
      <label><input type="checkbox" name="lang" value="php">PHP</label>
      <label><input type="checkbox" name="lang" value="js">JavaScript</label>
      <label><input type="checkbox" name="lang" value="cs">C#</label>
    </div>

    <div class="test">
      <input type="submit" value="submit" size="20"/>
    </div>
  </form>
</body>
</html>
