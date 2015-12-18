<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="get.aspx.vb" Inherits="mifosxcall._get" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <div class="col-lg-6">
    <asp:GridView ID="gvrecords" runat="server"  CssClass="table table-responsive table-hover table-striped" GridLines="None" SelectedIndex="0"   >
                <Columns>
 <asp:CommandField ButtonType="Image"  EditImageUrl="~/images/user.png" SelectImageUrl="~/images/user.png"  ShowSelectButton="True" />

                </Columns>
        <RowStyle CssClass="cursor-pointer" />
            </asp:GridView>



   </div>
     </div>
    </asp:Content>
