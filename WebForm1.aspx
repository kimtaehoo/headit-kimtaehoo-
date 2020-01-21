<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ASP>NET 웹 폼</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 387px">
            <h1>ASP.NET(4.7)</h1>
            <pre>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:TextBox ID="txtDisplay" runat="server"></asp:TextBox>
            
            <asp:Button ID="btnprint" runat="server" Text="인사" OnClick="btnprint_Click"  /> 
                
               <asp:Button ID="btnOutput" runat="server" Text="종료" OnClick="btnOutput_Click"  />
               
                
               
                <asp:Button ID="btnClick" runat="server" Height="29px" Text="클릭해주세요" OnClick="btnClick_Click" Width="171px" />
            
            <asp:Button ID="Button1" runat="server" Text="Button" />
            
            </pre>
        </div>
    </form>
</body>
</html>
