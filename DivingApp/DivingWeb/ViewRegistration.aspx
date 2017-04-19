<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewRegistration.aspx.cs" Inherits="ViewRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container_12">
            	<div class="a2">
                	<div class="wrapper">                 	
                        	<div class="col-7">
                            <h3 class="hp-1">List of Registrars</h3>
                                <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <h5><asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("AppUserID") %>'> <%# Eval("Name") %></asp:LinkButton></h5>
                                    </ItemTemplate>
                                </asp:Repeater>
              
                        </div>
                        <div class="col-8" style="margin-top:30px"> 
                            <h5><asp:Label ID="lblRegName" runat="server" Text=""></asp:Label></h5>                                                           
                           
                            

                            <h5> Address:</h5><asp:Label ID="lblRegAddress" runat="server" Text=""></asp:Label>
                            
                            <h5> Phone :</h5><asp:Label ID="lblRegPhone" runat="server" Text=""></asp:Label>
                            
                            <h5> Email :</h5><asp:Label ID="lblRegEmail" runat="server" Text=""></asp:Label>
                            
                            <h5> City:</h5><asp:Label ID="lblRegCity" runat="server" Text=""></asp:Label>
                            
                            <h5> Country:</h5><asp:Label ID="lblRegCountry" runat="server" Text=""></asp:Label>

                            <h5> Username:</h5><asp:Label ID="lblRegUsername" runat="server" Text=""></asp:Label><br /><br />

                            <%--<h5> Password:</h5><asp:Label ID="lblRegPass" runat="server" Text=""></asp:Label><br />--%>

                            <asp:Image ID="Image1" Width="100px" Height="100px" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

