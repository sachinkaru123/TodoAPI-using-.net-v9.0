using Microsoft.AspNetCore.Mvc;
using TodoAPI.Interface;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoServices _todoServices;

        public TodoController(ITodoServices todoServices)
        {
            _todoServices = todoServices;
        }

    }
}