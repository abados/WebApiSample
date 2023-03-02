using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApiExample.Controllers
{
	[ApiController]
	[Route("api/cities")]


	public class CitiesContoroller:ControllerBase
	{
		
		[HttpGet("list")]
		public JsonResult getList()
		{

			List<City> list = new List<City>();
			list.Add(new City() { Id = 10, Name = "RamatGan" });
			list.Add(new City() { Id = 11, Name = "TelAviv" });
			list.Add(new City() { Id = 12, Name = "Haifa" });
			list.Add(new City() { Id = 13, Name = "Jerusalem" });

			return new JsonResult(list);

			/* A way to do it with anonymus class
			return new JsonResult(new List<object>
			{
				new {id=10,name="RamatGan" },
				new {id=11,name="TelAviv" },
				new {id=12,name="Haifa" },
				new {id=13,name="Jerusalem" },
			});
		*/
		}

		[HttpGet("getOnecity{id}")]
		public JsonResult getOnecity(int id)
		{

			List<City> list = new List<City>();
			list.Add(new City() { Id = 10, Name = "RamatGan" });
			list.Add(new City() { Id = 11, Name = "TelAviv" });
			list.Add(new City() { Id = 12, Name = "Haifa" });
			list.Add(new City() { Id = 13, Name = "Jerusalem" });


			City city = list.Find(x=>x.Id== id);
			return new JsonResult(city);

		}

		[HttpPost("SaveCityData")]
		public JsonResult SaveCityData(int id, string name)
		{
			return new JsonResult("OK");
		}
	}
}
