

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    public IActionResult GetAllStudents()
    {
        return Ok(new List<string> { "Student1", "Student2", "Student3" });
    }
}