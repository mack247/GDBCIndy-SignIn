<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppWritesToAzureTables_WebRole._Default" %> 

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent"> 

    <div class="jumbotron"> 
        <br /> 
        <asp:Table 
            ID="Table1" 
            runat="server" GridLines="Both" CellPadding="10" CellSpacing="10"> 
            <asp:TableRow VerticalAlign="Top"> 
                <asp:TableCell> 
                    <h1>GDBC Indy Sign In</h1> 
                    <asp:Label ID="lblMessage" Text="" runat="server" /><br /> 
                    <asp:Label 
                        Text="Full Name" 
                        runat="server" /> 
                    <br /> 
                    <asp:TextBox 
                        ID="txtName" 
                        runat="server" 
                        Height="22px" 
                        Width="515px"> 
                    </asp:TextBox> 
                    <br /> 
                    <asp:Label 
                        Text="Email" 
                        runat="server" /> 
                    <br /> 
                    <asp:TextBox 
                        ID="txtEmail" 
                        runat="server" 
                        Height="22px" 
                        Width="515px"> 
                    </asp:TextBox> 
                    <br /> 
                    <asp:Label 
                        Text="Twitter" 
                        runat="server" /> 
                    <br /> 
                    <asp:TextBox 
                        ID="txtTwitter" 
                        runat="server" 
                        Height="22px" 
                        Width="515px"> 
                    </asp:TextBox> 
                    <br /> 
                    <asp:Button 
                        ID="cmdAddSignIn" 
                        runat="server" 
                        Text="Sign In" 
                        OnClick="cmdAddSignIn_Click" /> 
                </asp:TableCell> 
            </asp:TableRow> 
        </asp:Table> 
    </div> 
</asp:Content>