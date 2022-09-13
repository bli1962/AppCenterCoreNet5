﻿using mhcb.Syd.AppCenter.Services.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mhcb.Syd.Models;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.AppCenter.Pages.GUIDE.SettlementInf
{
    public class GetSettlementInfsByStatusBase : ComponentBase
    {
        [Inject]
        public ISettlementInfService _httpService { get; set; }
        [Inject]
        public IJSRuntime IJSRuntime { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        public IEnumerable<mhcb.Syd.DataAccess.Models.GUIDE.SettlementInf> settlementInf { get; set; } = new List<mhcb.Syd.DataAccess.Models.GUIDE.SettlementInf>();
        public string SelectedStatus { get; set; } = "F";

        protected override async Task OnInitializedAsync()
        {
            // modelView = (await _bankInfServiceService.GetPendingBIF()).ToList();
            //return base.OnInitializedAsync();
        }

        protected async Task SearchClick()
        {
            settlementInf = null;
            settlementInf = (await _httpService.GetSIFByStatus(SelectedStatus)).ToList();

            if (settlementInf.Count() == 0)
            {
                //await IJSRuntime.InvokeVoidAsync("alert", "No records found!");
                //bool confirmed = await IJSRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
                //string prompted = await IJSRuntime.InvokeAsync<string>("prompt", "Take some input :");

                //await IJSRuntime.InvokeVoidAsync("AlertMessage", "No Bank Information Found.");
                ComfirmationComponent.Show();
            }
        }
        protected async Task CopyClick()
        {
            //selectElementContents
            await IJSRuntime.InvokeAsync<object>("selectElementContents", "SelectedReport");
            await IJSRuntime.InvokeVoidAsync("alert", "Now you can paste the context to excel file.");
        }
        protected void BackClick()
        {
            navigationManager.NavigateTo($"/GUIDEReport");
        }

        //***********************************************************
        //  For Confirmation purpose codes
        //***********************************************************
        protected MizuhoRazorComponent.ConfirmYesBase ComfirmationComponent { get; set; }
        protected async Task ConfirmClick(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                //await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                //navigationManager.NavigateTo("/");
            }
        }
    }
}
