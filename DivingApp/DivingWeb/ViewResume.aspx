<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewResume.aspx.cs" Inherits="ViewResume" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container_12">
            	<div class="a2">
                	<div class="wrapper">                 	
                        	<div class="col-7">
                            <h3 class="hp-1">RESUMES</h3>
                                <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                        <h5><asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ResumeID") %>'> <%# Eval("Name") %></asp:LinkButton></h5>
                                    </ItemTemplate>
                                </asp:Repeater>
              
                        </div>
                        <div class="col-8" style="margin-top:30px"> 
                            <h3><asp:Label ID="lblresumename" runat="server" Text=""></asp:Label></h3>                                                           
                           
                            

                            <h5> Experience :</h5><asp:Label ID="lblResumeExperience" runat="server" Text=""></asp:Label>
                            
                            <h5> Qualification :</h5><asp:Label ID="lblResumeQualification" runat="server" Text=""></asp:Label>
                            
                            <h5> Certificate Courses :</h5><asp:Label ID="lblResumeCertificateCourses" runat="server" Text=""></asp:Label>
                            
                            <h5> Latest Diving Spot:</h5><asp:Label ID="lblResumeDivingSpot" runat="server" Text=""></asp:Label>
                            
                            <h5> Diving Spots Visited:</h5><asp:Label ID="lblSpotsVisited" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

