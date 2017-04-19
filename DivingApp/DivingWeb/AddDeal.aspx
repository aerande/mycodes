<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddDeal.aspx.cs" Inherits="AddDeal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. August20, 2012!</div>
            <div class="container_12">
            	<article class="a2">
                	<div class="wrapper">
                    	
                        <div class="col-12">
                        	<h3>ADD A DEAL</h3>
                            
                              <fieldset>
                              <table class="formtable">

                              <tr><td style="min-width:150px;">Title:</td><td>
                                <label class="name">
                                    
                                <asp:TextBox ID="txtdealtitle" runat="server" Text=""></asp:TextBox></label>
                             </td></tr>

                             <tr>
                             <td style="min-width:150px;">Description:</td>
                             <td>
                             <label class="message">
                             <asp:TextBox ID="txtdealdesc" runat="server"></asp:TextBox>
                             </label>
                             </td>
                             </tr>

                             

                         </table><br />

                         <asp:FileUpload ID="photoupload" runat="server"></asp:FileUpload><br /><br />

                                <div class="btns">
<asp:Button ID="btnSave" runat="server" Text="Save" class="button" onclick="btnSave_Click"></asp:Button>

                              
                                </div>
                              </fieldset>
                           
                        </div>
                    </div>
                </article>
            </div>
        </section>
    <br />
    <br />
</asp:Content>

