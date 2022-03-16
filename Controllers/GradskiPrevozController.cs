
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebProjekat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradskiPrevozController : ControllerBase
    {
        public ProjekatContext Context { get; set; }

        public GradskiPrevozController(ProjekatContext context) 
        {
            Context = context;
        }
        [Route("PreuzmiRadnike/{LinijaID}")]
        [HttpGet]
        public async Task<ActionResult> PreuzmiRadnike(int LinijaID) 
        {
            var tabela = Context.AutobusiLinija
                .Include(p => p.Autobus);
            var radnik = tabela.Where(p => p.Linija.ID == LinijaID).Select(p => p.Autobus.Radnik.ID).FirstOrDefault();
            var radnik1 = Context.Radnici.FindAsync(radnik);
            
            return Ok(await radnik1);
        }

        [Route("PreuzmiLinije")]
        [HttpGet]
        public async Task<ActionResult> PreuzmiLinije() 
        {
            try
            {
                return Ok(await Context.Linije.Select(p => new { p.ID, p.BrojLinije, p.NazivLinije}).ToListAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("PreuzmiCenu/{LinijaID}")]
        [HttpGet]
        public ActionResult PreuzmiCenu(int LinijaID)
        {
            try
            {
                return Ok(Context.Linije.Where(p => p.ID == LinijaID).Select(p => p.Zona.CenaKarte).FirstOrDefault());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("DodatiZonu")]
        [HttpPost]
        public async Task<ActionResult> DodajZonu([FromBody] Zona zona)
        {
            if(zona.BrojZone < 1 || zona.BrojZone > 4)
            {
                return BadRequest("Pogresan broj zone");
            }
            if(string.IsNullOrWhiteSpace(zona.NazivZone) || zona.NazivZone.Length > 50)
            {
                return BadRequest("Pogresan naziv");
            }
            try 
            {
                Context.Zone.Add(zona);
                await Context.SaveChangesAsync();
                return Ok($"U redu! ID je: {zona.ID}");
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }

        [Route("PromenitiZonu/{brojZone}/{nazivZone}")]
        [HttpPut]
        public async Task<ActionResult> PromeniZonu(int brojZone, string nazivZone)
        {
            if(brojZone > 4 || brojZone < 1)
            {
                return BadRequest("Pogresan broj zone");
            }
            try 
            {
                var zona = Context.Zone.Where(p => p.BrojZone == brojZone).FirstOrDefault();
                
                if(zona != null)
                {
                    zona.BrojZone = brojZone;
                    zona.NazivZone = nazivZone;

                    await Context.SaveChangesAsync();
                    return Ok("Uspesno promenjena zona!");
                }
                else
                {
                    return BadRequest("Zona nije pronadjena!");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("PromenitiZonuFromBody")]
        [HttpPut]
        public async Task<ActionResult> PromeniBody([FromBody] Zona zona)
        {
            if(zona.BrojZone < 1 || zona.BrojZone > 4)
            {
                return BadRequest("Pogresan broj zone");
            }
            try
            {
                var zonaZaPromenu = Context.Zone.Where(p => p.BrojZone == zona.BrojZone).FirstOrDefault();
                if(zonaZaPromenu != null)
                {
                    zonaZaPromenu.NazivZone = zona.NazivZone;
                    zonaZaPromenu.CenaKarte = zona.CenaKarte;

                    await Context.SaveChangesAsync();
                    return Ok($"Zona sa brojem {zona.BrojZone} je uspesno izmenjena");
                }
                else
                {
                    return BadRequest("Zona nije pronadjena!");
                }
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }

        [Route("IzbrisatiZonu/{brojZone}")]
        [HttpDelete]
        public async Task<ActionResult> Izbrisi(int brojZone) 
        {
            if(brojZone < 1 || brojZone > 4)
            {
                return BadRequest("Pogresan broj");
            }
            try 
            {
                var zona = Context.Zone.Where(p => p.BrojZone == brojZone).FirstOrDefault();
                if(zona != null)
                {
                    Context.Zone.Remove(zona);
                    await Context.SaveChangesAsync();
                    return Ok($"Uspesno obrisana zona sa brojem {brojZone}");
                }
                else
                {
                    return BadRequest("Zona nije pronadjena!");
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        } 
    }
}
