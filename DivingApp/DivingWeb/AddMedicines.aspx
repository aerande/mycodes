﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddMedicines.aspx.cs" Inherits="AddMedicines" %>

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
                        	<h3>ADD A NEW MEDICINE</h3>
                            
                              <fieldset>
                              <table class="formtable">

                              <tr><td style="min-width:150px;">  Name: </td><td>
                                <label class="name">
                                    
                                <asp:TextBox ID="txtMediName" runat="server" Text=""></asp:TextBox></label>
                             </td></tr>
                            <tr><td> 
                            
                              

  <tr><td>Description:</td><td><label class="message">
                                  
<asp:TextBox TextMode="MultiLine" ID="txtMediDesc" runat="server" ></asp:TextBox>
                                </label></td></tr>

                                <tr>
                                <td>Cost:</td>
                                <td>
                                <label class="name">
                                <asp:TextBox ID="txtMediCost" runat="server"></asp:TextBox>
                                </label>
                                </td>
                                </tr>

                                <tr>
                                <td>Purpose:</td>
                                <td><label class="message">
                                <asp:TextBox TextMode="MultiLine" ID="txtMediPurpose" runat="server" ></asp:TextBox>
                                </label></td></tr>
                                </tr>
                               
                               
                                
                             
                                

                                </table>
                                <div class="btns">
<asp:Button ID="MediSave" runat="server" Text="Save" class="button" onclick="MediSave_Click"></asp:Button>

                              
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

