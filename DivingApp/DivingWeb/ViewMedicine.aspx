<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewMedicine.aspx.cs" Inherits="ViewMedicine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container_12">
            	<div class="a2">
                	<div class="wrapper">                 	
                        	<div class="col-7">
                            <h3 class="hp-1">List of Medicines</h3>
                                <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <h5><asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("MedicineID") %>'> <%# Eval("Name") %></asp:LinkButton></h5>
                                    </ItemTemplate>
                                </asp:Repeater>
              
                        </div>
                        <div class="col-8" style="margin-top:30px"> 
                            <h3><asp:Label ID="lblmediname" runat="server" Text=""></asp:Label></h3>                                                           
                           
                            <h5> Description :</h5><asp:Label ID="lblmedidesc" runat="server" Text=""></asp:Label>

                            <h5> Cost :</h5><asp:Label ID="lblmedicost" runat="server" Text=""></asp:Label>
                            
                            <h5> Purpose :</h5><asp:Label ID="lblmedipurpose" runat="server" Text=""></asp:Label>
                            
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

