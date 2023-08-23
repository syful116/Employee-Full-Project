using EmployeeManageentProject4.Forntend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmployeeManageentProject4.Forntend.Controllers;
public  class CityController : Controller
{
    private readonly HttpClient _httpClient;
    public CityController()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://localhost:7218/api/");
    }
    public async Task<ICollection<City>> GetAllCity()
    {
        var data = await _httpClient.GetAsync("City");
        if (data.IsSuccessStatusCode)
        {
            var newData = await data.Content.ReadAsStringAsync();
            var City = JsonConvert.DeserializeObject<List<City>>(newData);
            return City;
        }
        return new List<City>();
    }
    public async Task<IActionResult> Index()
    {
        var data = await GetAllCity();
        return View(data);
    }
    [HttpGet]
    public async Task<IActionResult> AddorEdit(int id)
    {
        if (id == 0)
        {
            return View(new City());
        }
        else
        {
            var response = await _httpClient.GetAsync($"City/{id}");
            if (response.IsSuccessStatusCode)
            {
                var city = await response.Content.ReadFromJsonAsync<City>();
                return View(city);
            }
            else
            {
                return NotFound();
            }
        }
    }
    [HttpPost]
    public async Task<IActionResult> AddorEdit(City city, int id)
    {
        if (id == 0)
        {
            //save//

            var data = await _httpClient.PostAsJsonAsync("City", city);
            if (data.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        else
        {
            //update//
            if (id != city.id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PutAsJsonAsync($"City/{id}", city);

                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to update the City.");
                    return View(city);
                }
            }
            return View(city);
        }
        return View(new City());
    }

    public async Task<ActionResult> Delete(int id)
    {
        var response = await _httpClient.DeleteAsync($"City/{id}");
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }

}
