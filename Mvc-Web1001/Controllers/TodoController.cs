public IActionResult Index()
{
    var todoItems=_context.TodoItems.TodoList();
    return View(todoItems);
}

public IActionResult Create()
{
    var todoItems=_context.TodoItems.TodoList();
    return View(todoItems);
}

public IActionResult Edit()
{
    var todoItems=_context.TodoItems.TodoList();
    return View(todoItems);
}

public IActionResult Delete()
{
    var todoItems=_context.TodoItems.TodoList();
    return View(todoItems);
}