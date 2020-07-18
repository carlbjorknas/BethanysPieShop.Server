using BethanysPieShopHRM.ComponentsLibrary.Map;
using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Server.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }

		[Parameter]
		public string EmployeeId { get; set; }

		public Employee Employee { get; set; } = new Employee();

		public List<Marker> MapMarkers { get; set; } = new List<Marker>();

		protected async override Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
			MapMarkers = new List<Marker>
			{
				new Marker
				{
					Description = $"{Employee.FirstName} {Employee.LastName}",
					ShowPopup = false,
					X = Employee.Longitude,
					Y = Employee.Latitude
				}
			};
		}		
	}
}
