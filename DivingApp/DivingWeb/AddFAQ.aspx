<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddFAQ.aspx.cs" Inherits="AddFAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
        .formtable tr td
        {
            margin: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. August20, 2012!</div>
            <div class="container_12">
            	<article class="a2">
                	<div class="wrapper">
                    	
                        <div class="col-12">
                        	<h3>ADD FAQ</h3>
                            
                              <fieldset>
                              <table class="formtable">

                              <tr><td style="min-width:150px;">  QUERY: </td><td>
                                <label class="name">
                                    
                                <asp:TextBox ID="txtQuery" runat="server" Text="" ></asp:TextBox></label>
                             </td></tr>

                            <tr><td>ANSWER:</td><td><label class="message">
                                  
<asp:TextBox TextMode="MultiLine" ID="txtAnswer" runat="server" ></asp:TextBox>
                                </label></td></tr>
                               
                               
                                </table>
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

