<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
.error
{
    color: #ff0000;
    font-family: Times New Roman;
    font-size: medium;
}

.input-block-level {
  display: block;
  width: 100%;
  min-height: 30px;
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

.formtable tr td
{
    margin: 10px;
}

</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width:100%; text-align:center;">
        <div style="width:100%;padding-top: 50px; padding-bottom:50px;">
            <center>
            <fieldset>
                            
                <h2>Please Sign In</h2>
                <asp:Label CssClass="error" ID="lblerror" runat="server" Text=""></asp:Label>
              
            <table>
            <tr>
            <td>Username:</td>
            <td><asp:TextBox CssClass="input-block-level" ID="txtusername" runat="server"></asp:TextBox></td>
            </tr>
            <br />
          
            <tr>
            <td>Password:</td>
            <td><asp:TextBox CssClass="input-block-level" ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
            
            
            </table>
            <br />

            
            <asp:Button CssClass="button" ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click" />
            
            </fieldset>
            </center>
        </div>
    </div>
     
    
   </asp:Content>
