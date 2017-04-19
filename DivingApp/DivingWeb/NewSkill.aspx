<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="NewSkill.aspx.cs" Inherits="NewSkill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .formtable tr td
        {
            margin: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. August20, 2012!</div>
            <div class="container_12">
            	<article class="a2">
                	<div class="wrapper">
                    	
                        <div class="col-12">
                        	<h3>ADD A NEW SKILL</h3>
                            
                              <fieldset>
                              <table class="formtable">

                              <tr><td style="min-width:150px;">  Name: </td><td>
                                <label class="name">
                                    
                                <asp:TextBox ID="txtName" runat="server" Text="" ></asp:TextBox></label>
                             </td></tr>
                            <tr><td> Type:</td><td> <label class="phone">
  <asp:DropDownList ID="ddlType" runat="server">
  <asp:ListItem Text="Basic Skill" Value="Basic Skill" />
  <asp:ListItem Text="Advanced Skill" Value="Advanced Skill" />
  </asp:DropDownList>
                                </label></td></tr>

  <tr><td>Description:</td><td><label class="message">
                                  
<asp:TextBox TextMode="MultiLine" ID="txtDesc" runat="server" ></asp:TextBox>
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
