using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListApi.Data;
using TodoListModels;

[Route("api/[controller]")]
[ApiController]
public class TodoItemsController : ControllerBase
{
    private readonly TodoListContext _context;

    public TodoItemsController(TodoListContext context)
    {
        _context = context;
    }

    // GET: api/todoitems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
    {
        return await _context.TodoItems.Where(t => t.CompletedDate == null).ToListAsync();
    }

    // GET: api/todoitems/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> GetTodoItem(int id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }

    // POST: api/todoitems
    [HttpPost]
    public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
    {
        _context.TodoItems.Add(todoItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
    }

    // PUT: api/todoitems/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodoItem(int id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        todoItem.CompletedDate = DateTime.UtcNow;

        _context.Entry(todoItem).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
