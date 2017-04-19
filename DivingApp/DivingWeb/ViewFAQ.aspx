<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewFAQ.aspx.cs" Inherits="ViewFAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container_12">
            	<div class="a2">
                	<div class="wrapper">                 	
                        	<div class="col-7">
                            <h3 class="hp-1">FAQs</h3>
                                <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <h5><asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("FAQID") %>'> <%# Eval("Title") %></asp:LinkButton></h5>
                                    </ItemTemplate>
                                </asp:Repeater>
              
                        </div>
                        <div class="col-8" style="margin-top:30px"> 
                            <h3><asp:Label ID="lblskillname" runat="server" Text=""></asp:Label></h3>                                                           
                           
                            <h5> Title :</h5><asp:Label ID="lblFAQTitle" runat="server" Text=""></asp:Label>

                            <h5> Description :</h5><asp:Label ID="lblFAQDesc" runat="server" Text=""></asp:Label>

                            <h5> Upload Time :</h5><asp:Label ID="lblFAQTime" runat="server" Text=""></asp:Label>
                            
                                                                                  
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

