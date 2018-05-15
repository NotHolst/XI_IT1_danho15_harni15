using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.AspNetCore.NewDb.Models;

namespace Vue2Spa.Controllers
{
    [Produces("application/json")]
    [Route("api/CmsContent")]
    public class CmsContentController : Controller
    {
        private readonly ProjectContext _context;

        public CmsContentController(ProjectContext context)
        {
            _context = context;
        }

        // GET: api/CmsContent
        [HttpGet]
        public IEnumerable<CmsContent> GetCmsContent()
        {
            return _context.CmsContent;
        }

        // GET: api/CmsContent/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCmsContent([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cmsContent = await _context.CmsContent.SingleOrDefaultAsync(m => m.Id == id);

            if (cmsContent == null)
            {
                return NotFound();
            }

            return Ok(cmsContent);
        }

        // PUT: api/CmsContent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCmsContent([FromRoute] string id, [FromBody] CmsContent cmsContent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cmsContent.Id)
            {
                return BadRequest();
            }

            _context.Entry(cmsContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CmsContentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CmsContent
        [HttpPost]
        public async Task<IActionResult> PostCmsContent([FromBody] CmsContent cmsContent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CmsContent.Add(cmsContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCmsContent", new { id = cmsContent.Id }, cmsContent);
        }

        // DELETE: api/CmsContent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCmsContent([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cmsContent = await _context.CmsContent.SingleOrDefaultAsync(m => m.Id == id);
            if (cmsContent == null)
            {
                return NotFound();
            }

            _context.CmsContent.Remove(cmsContent);
            await _context.SaveChangesAsync();

            return Ok(cmsContent);
        }

        private bool CmsContentExists(string id)
        {
            return _context.CmsContent.Any(e => e.Id == id);
        }
    }
}