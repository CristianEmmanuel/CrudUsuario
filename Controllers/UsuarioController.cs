using CrudUsuario.Data;
using CrudUsuario.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ServiceContext contexto;

        public UsuariosController(ServiceContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
        
            return await this.contexto.Usuarios.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuarios(Usuario usuario)
        {
            var exist = await this.contexto.Usuarios.FirstOrDefaultAsync(x => x.Identificacion == usuario.Identificacion);
           
            await this.contexto.Usuarios.AddAsync(usuario);
            await this.contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuario), new { identificacion = usuario.Identificacion }, usuario);
        }

        [HttpPut]
        public async Task<ActionResult> PutUsuario(Usuario usuario)
        {
            this.contexto.Entry(usuario).State = EntityState.Modified;
            await this.contexto.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<Usuario> DeleteUsuario(int id)
        {
            var find = await this.contexto.Usuarios.FindAsync(id);
            //if (find is null)
            //{
            //    return NotFound();
            //}
            this.contexto.Remove(find);
            return find;
        }

    }
}
