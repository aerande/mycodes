<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
                        	<h3>REGISTER</h3>
                            
                              <fieldset>
                              <table class="formtable">

                              <tr><td style="min-width:150px;">  Name: </td><td>
                                <label class="name">
                                    
                                <asp:TextBox ID="txtName" runat="server" Text="" ></asp:TextBox></label>
                             </td></tr>
                            

  <tr><td>Address:</td><td><label class="message">
                                  
<asp:TextBox TextMode="MultiLine" ID="txtAddress" runat="server" ></asp:TextBox>
                                </label></td></tr>
                               
   <tr><td>Phone:</td><td><label class="message">
                                  
<asp:TextBox ID="txtPhone" runat="server" ></asp:TextBox>
                                </label></td></tr>
                               
                                
 <tr><td>Email:</td><td><label class="message">
                                  
<asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                                </label></td></tr>
                               
   <tr><td>City</td><td><label class="message">
                                  
<asp:TextBox ID="txtCity" runat="server" ></asp:TextBox>
                                </label></td></tr>
                                
<tr><td>Country:</td><td><label class="message">
                                  
<asp:TextBox ID="txtCountry" runat="server" ></asp:TextBox>
                                </label></td></tr>
   
   <tr><td>Username:</td><td><label class="message">
                                  
<asp:TextBox ID="txtUsername" runat="server" ></asp:TextBox>
                                </label></td></tr>
   
   <tr><td>Password:</td><td><label class="message">
                                  
<asp:TextBox TextMode="Password" ID="txtPassword" runat="server" ></asp:TextBox>
                                </label></td></tr>
   
 
   
                                </table><br />
<asp:FileUpload ID="photoupload" runat="server"></asp:FileUpload><br />
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

