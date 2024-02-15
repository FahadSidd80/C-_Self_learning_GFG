<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterestCalculator.aspx.cs" Inherits="WebApp_Calculte_interest.InterestCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>No of Months :</td>
                    <td><asp:TextBox ID="txtnofomonths" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Differnce Amount :</td>
                    <td><asp:TextBox ID="txtdiffamount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Interst Amount 1st Month :</td>
                    <td><asp:TextBox ID="txtinterestamount1stmonth" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Extra Amount per month :</td>
                    <td><asp:TextBox ID="txtextraamount" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btncalculate" runat="server" Text="Calculate" OnClick="btncalculate_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
