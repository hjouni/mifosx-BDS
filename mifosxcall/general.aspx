<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="general.aspx.vb" Inherits="mifosxcall.general" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="tab-content">
		<div class="tab-pane active" id="tabPageEmployee">
			<div id="Employee" class="reviewBlock" data-content="List" style="padding-left: 5px;"><div class="row">
	<div class="col-xs-12 col-md-2">
		<div class="row-fluid">
			<div class="col-xs-12" style="text-align: center;">
				<img id="profile_image_5" src='#' class="img-polaroid img-thumbnail" style="max-width: 140px;max-height: 140px;"> 
			</div>
		 	
		</div>
	</div>
    <div class="col-xs-12 col-md-10">
    	<div class="row-fluid">
			<div class="col-md-12"><h2 id="name"><asp:Label runat="server" ID="Labelname"></asp:Label></h2></div>
		</div>	
		<div class="row-fluid">
			<div class="col-md-12">
			<p>
				<i class="fa fa-phone"></i> <span id="mobile_phone"></span>&nbsp;&nbsp;
				<i class="fa fa-envelope"></i> <span id="work_email"></span>
			</p>
			</div>
		</div>
	    <div class="row-fluid">
	    	<div class="col-xs-12" style="font-size:18px;border-bottom: 1px solid #DDD;margin-bottom: 10px;padding-bottom: 10px;">
				<asp:button runat="server" id="employeeProfileEditInfo" class="btn btn-small btn-success"  style="margin-right:10px;" Text=" Add BDS INFO "></asp:button>
				


			</div>
	    </div>
	    
	    <div class="row-fluid" style="border-top: 1px;">
			<div class="col-xs-6 col-md-4" style="font-size:16px;">
				<label class="control-label col-xs-12" style="font-size:13px;font-size:13px;">Employee Number</label>
				<asp:label runat="server" class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="labelid"></asp:label>
			</div>
			<!--<div class="col-xs-6 col-md-4" style="font-size:16px;">
				<label class="control-label col-xs-12" style="font-size:13px;">State</label>
				<asp:label runat="server" class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="test"></asp:label>
			</div>
			<div class="col-xs-6 col-md-4" style="font-size:16px;">
				<label class="control-label col-xs-12" style="font-size:13px;">SSN/NRIC</label>
				<label class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="ssn_num"></label>
			</div> -->
		</div>
    </div>
</div>


<ul class="nav nav-tabs" id="subModTab" style="margin-bottom:0px;margin-left:5px;border-bottom: none;">
	<li class="active"><a id="tabBasic" href="#tabPageBasic">Basic Information</a></li>
</ul>

<div class="tab-content">
	<div class="tab-pane active" id="tabPageBasic" style="border:1px solid #DDD;">
		<div class="row" style="margin-left:10px;margin-top:20px;">
			<div class="panel panel-default" style="width:97.5%;">
				<div class="panel-heading"><h4>Personal Information</h4></div>
				<div class="panel-body">
				<div class="row-fluid">
				<!--	<div class="col-xs-6 col-md-3" style="font-size:16px;">
						<label class="control-label col-xs-12" style="font-size:13px;">Driver's License Number</label>
						<label class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="driving_license"></label>
					</div> -->
					<div class="col-xs-6 col-md-3" style="font-size:16px;">
						<label class="control-label col-xs-12" style="font-size:13px;">Account#</label>
						<asp:label runat="server" class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="Labelgov"></asp:label>
					</div>
					
					<div class="col-xs-6 col-md-3" style="font-size:16px;">
						<label class="control-label col-xs-12" style="font-size:13px;">office</label>
						<asp:label runat="server" class="control-label col-xs-12 iceLabel" style="font-size:13px;font-weight: bold;" id="Labelgender"></asp:label>
					</div>
				</div>	
				<hr>  
			   
				</div>
		    </div>
		</div>
		
	</div>
		
	</div>
    </div>
    </div>
    </div>
</asp:Content>
