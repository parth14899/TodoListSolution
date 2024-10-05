using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoListModels;

namespace TodoListApi.Data
{
    public class TodoListContext : DbContext
    {
        private DbSet<TodoItem> todoItems;

        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get => todoItems; set => todoItems = value; }
    }
}
