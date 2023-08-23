using EmployeeManageentProject4.Forntend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace EmployeeManageentProject4.Forntend.Controllers;

public class DepartmentController : Controller
{
    private readonly HttpClient _httpClient;
    public DepartmentController()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://localhost:7218/api/");
    }
    public async Task<List<Department>> GetAllDepartment()
    {
        var data = await _httpClient.GetAsync("Department");
        if (data.IsSuccessStatusCode)
        {
            var newData = await data.Content.ReadAsStringAsync();
            var departments = JsonConvert.DeserializeObject<List<Department>>(newData);
            return departments;
        }
        return new List<Department>();
    }
    public async Task<IActionResult> Index()
    {
        var data = await GetAllDepartment();
        return View(data);
    }
    [HttpGet]
    public async Task<IActionResult> AddorEdit(int id)
    {
        if (id == 0)
        {
            return View(new Department());
        }
        else
        {
            var response = await _httpClient.GetAsync($"Department/{id}");
            if (response.IsSuccessStatusCode)
            {
                var departments = await response.Content.ReadFromJsonAsync<Department>();
                return View(departments);
            }
            else
            {
                return NotFound();
            }
        }
    }
    [HttpPost]
    public async Task<IActionResult> AddorEdit(Department department, int id)
    {
        if (id == 0)
        {
            //save//
            var data = await _httpClient.PostAsJsonAsync("Department", department);
            if (data.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        else
        {
            //update//
            if (id != department.id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PutAsJsonAsync($"Department/{id}", department);

                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to update the Department.");
                    return View(department);
                }
            }
            return View(department);
        }
        return View(new Department());
    }

    public async Task<ActionResult> Delete(int id)
    {
        var response = await _httpClient.DeleteAsync($"Department/{id}");
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



