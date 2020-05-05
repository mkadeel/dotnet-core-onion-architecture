using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Entities.Items;
using Onion.Interfaces.Services;

namespace Onion.WebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly IBaseService<Item> _ItemService;
        public ItemController(IBaseService<Item> ItemService)
        {
            _ItemService = ItemService;
        }

        public IActionResult Index()
        {
            var allItems = _ItemService.GetAll();
            return Ok(allItems);
        }
    }
}