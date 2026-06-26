[HttpPut("{id}")]
public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmp) {
    if (id <= 0) return BadRequest("Invalid employee id");
    
    var emp = employeeList.FirstOrDefault(e => e.Id == id);
    if (emp == null) return BadRequest("Invalid employee id");

    emp.Name = updatedEmp.Name;
    emp.Salary = updatedEmp.Salary;
    return Ok(emp);
}