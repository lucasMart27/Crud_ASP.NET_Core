using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCrudLogAuditorio.Data;
using WebCrudLogAuditorio.Models;

namespace WebCrudLogAuditorio.Controllers
{
    public class LogAuditoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogAuditoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LogAuditorias
        public async Task<IActionResult> Index()
        {
            return View(await _context.LogAuditoria.ToListAsync());
        }

       
    }
}
