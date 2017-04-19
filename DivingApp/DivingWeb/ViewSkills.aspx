<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewSkills.aspx.cs" Inherits="ViewSkills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    .grid td{
        padding:10px;
    }
    .grid th
    {
        text-align:left;
         padding:10px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. August20, 2012!</div>
            <div class="container_12">
            	<article class="a2">
                	<div class="wrapper">
                    	
                        <div class="col-12">
                        	<h3>VIEW SKILLS</h3>

                           <asp:GridView ID="GridView1" runat="server" class="grid" AutoGenerateColumns="false" Width="800px">
                            <Columns>
                                <asp:TemplateField HeaderText="Name">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            

                                 <asp:TemplateField HeaderText="Type">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("IsActive") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Time">
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("UploadTime") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Details">
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                           </asp:GridView>
                           

                           
               <div class="btns">

<a href="NewSkill.aspx" class="button">ADD</a>
                              
                                </div>
                        </div>
                    </div>
                </article>
            </div>
        </section>
    <br />
    <br />
</asp:Content>

