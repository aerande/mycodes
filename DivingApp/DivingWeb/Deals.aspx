<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Deals.aspx.cs" Inherits="Deals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container_12">
            	<div class="a2">
                	<div class="wrapper">                 	
                        	<div class="col-7">
                            <h3 class="hp-1">Dive Deals</h3>

                                <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("DealID") %>' ImageUrl='<%# Eval("PhotoPath") %>' Width="150px" Height="100px"/><br /><br />
                                    </ItemTemplate>
                                </asp:Repeater>
                             </div>

                             <div class="col-8" style="margin-top:30px"> 
                             <h3><asp:Label ID="lbldealtitle" runat="server" Text=""></asp:Label></h3> 

                             <h5> Description :</h5><asp:Label ID="lbldealdesc" runat="server" Text=""></asp:Label>
                             </div>
                     </div>                     
                </div>
            </div>

</asp:Content>

