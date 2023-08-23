using EmployeeManageentProject4.Forntend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmployeeManageentProject4.Forntend.Controllers;

public class StateController : Controller


{
    private readonly HttpClient _httpClient;
  public StateController()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://localhost:7218/api/");
    }
    public async Task<IEnumerable<State>> GetAllState()
    {
        var data = await _httpClient.GetAsync("State");
        if (data.IsSuccessStatusCode)
        {
            var newData = await data.Content.ReadAsStringAsync();
            var state = JsonConvert.DeserializeObject<List<State>>(newData);
            return state;
        }
        return new List<State>();
    }
    public async Task<IActionResult> Index()
    {
        var data = await GetAllState();
        return View(data);
    }
    [HttpGet]
    public async Task<IActionResult> AddorEdit(int id)
    {
        if (id == 0)
        {
            return View(new State());
        }
        else
        {
            var response = await _httpClient.GetAsync($"State/{id}");
            if (response.IsSuccessStatusCode)
            {
                var state = await response.Content.ReadFromJsonAsync<State>();
                return View(state);
            }
            else
            {
                return NotFound();
            }
        }
    }
    [HttpPost]
    public async Task<IActionResult> AddorEdit(State state, int id)
    {
        if (id == 0)
        {
            //save//
            var data = await _httpClient.PostAsJsonAsync("State", state);
            if (data.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        else
        {
            //update//
            if (id != state.id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PutAsJsonAsync($"State/{id}", state);

                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to update the State.");
                    return View(state);
                }
            }
            return View(state);
        }
        return View(new State());
    }

    public async Task<ActionResult> Delete(int id)
    {
        var response = await _httpClient.DeleteAsync($"State/{id}");
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