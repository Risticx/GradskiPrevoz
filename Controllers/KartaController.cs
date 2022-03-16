
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
    public class KartaController : ControllerBase
    {
        public ProjekatContext Context { get; set; }

        public KartaController(ProjekatContext context) 
        {
            Context = context;
        }

        [Route("PreuzmiZonu/{LinijaID}")]
        [HttpGet]
        public ActionResult PreuzmiZonu(int LinijaID)
        {
            var tabela = Context.Linije
                .Include(p => p.Zona)
                .Include(p => p.LinijaAutobus)
                .ThenInclude(p => p.Autobus);

            var zonaInfo = tabela.Where(p => p.ID == LinijaID).Select(p => p.Zona.NazivZone);

            return Ok(zonaInfo);
        }

        [Route("PreuzmiReg/{LinijaID}")]
        [HttpGet]
        public ActionResult PreuzmiReg(int LinijaID)
        {
            var tabela = Context.Linije
            .Include(p => p.Zona)
            .Include(p => p.LinijaAutobus)
            .ThenInclude(p => p.Autobus);

            var regInfo = tabela.Where(p => p.ID == LinijaID).Select(p => p.LinijaAutobus.Select(p => p.Autobus.RegistarskaOznaka));

            return Ok(regInfo);
        }

        [Route("DodajKartu/{brojKarte}/{cenaKarte}/{radnikID}")]
        [HttpPost]
         public async Task<ActionResult> DodajKartu(int brojKarte, int cenaKarte, int radnikID)
         {
            if(brojKarte < 1)
            {
                return BadRequest("Neispravan broj karte!");
            }
            
            try
            {
                var radnik = await Context.Radnici.FindAsync(radnikID);
                
                if(radnik.RadnoMesto == "Kondukter") 
                {
                    Karta k = new Karta
                    {
                        BrojKarte = brojKarte,
                        CenaKarte = cenaKarte,
                        VremeIzdavanja = DateTime.Now,
                        Radnik = radnik
                        
                    };
                    Context.Karte.Add(k);
                    await Context.SaveChangesAsync();
                    return Ok("Karta dodata!");
                }
                else
                {
                    return BadRequest("Samo kondukter moze izdati kartu");
                }
            }
            catch(Exception e) 
            {
                return BadRequest(e.Message);
            }
        }  

        [Route("PreuzmiKarte")]
        [HttpGet]
        public async Task<ActionResult> Karte() 
        {
            try
            {
                return Ok(await Context.Karte.Select(p => new {p.ID, p.BrojKarte, p.VremeIzdavanja, p.CenaKarte, p.Radnik.Ime, p.Radnik.Prezime}).ToListAsync());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("KartaMax")]
        [HttpGet]
        public async Task<ActionResult> KartaMax() 
        {
             var max = await  Context.Karte.Select(p => p.BrojKarte).MaxAsync();
             return Ok(max);
        }
    }
}    