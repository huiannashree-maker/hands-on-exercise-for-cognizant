public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public bool Permanent { get; set; }
}

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase {
    [HttpGet]
    [ProducesResponseType(200)]
    public ActionResult<List<Employee>> Get() {
        return Ok(new List<Employee> { new Employee { Id = 1, Name = "John Doe" } });
    }
}