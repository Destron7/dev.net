using Microsoft.AspNetCore.Mvc;

using UserManagementAPI.Models;

[ApiController]

[Route("api/[controller]")]

public class UsersController : ControllerBase

{

    private static List<User> _users = new List<User>

    {

        new User { Id = 1, Name = "John Doe", Email = "john@example.com", Department = "HR" }

    };

    private static int _nextId = 2;

    [HttpGet]

    public IEnumerable<User> Get()

    {

        return _users;

    }

    [HttpGet("{id}")]

    public ActionResult<User> Get(int id)

    {

        var user = _users.FirstOrDefault(u => u.Id == id);

        if (user == null)

        {

            return NotFound();

        }

        return user;

    }

    [HttpPost]
    public ActionResult<User> Post([FromBody] User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        user.Id = _nextId++;
        _users.Add(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var existingUser = _users.FirstOrDefault(u => u.Id == id);
        if (existingUser == null)
        {
            return NotFound();
        }

        existingUser.Name = user.Name;
        existingUser.Email = user.Email;
        existingUser.Department = user.Department;
        return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)

    {

        var user = _users.FirstOrDefault(u => u.Id == id);

        if (user == null)

        {

            return NotFound();

        }

        _users.Remove(user);

        return NoContent();

    }

}