using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using bracket_api.Models;

namespace bracket_api.Controllers
{
    public class BracketController : ControllerBase
    {
        private readonly BracketContext _context;

        public BracketController(BracketContext context)
        {
            _context = context;
        }
    }
}
