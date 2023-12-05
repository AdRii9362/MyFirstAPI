using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonAPI.Models;

namespace MonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly FakeDB _FDB = new FakeDB();
        //On signifie ce que l on veut faire
        // ajout d une nouvelle methode: GetAll qui affiche toutes les données
        [HttpGet(nameof(GetAll))]
        //La logique pour recuperer nos éléments
        public IEnumerable<Utilisateur> GetAll()
        {
            return _FDB.Utilisateurs;
        }


        // ajout d une nouvelle methode: recherche selon l ID
        [HttpGet("{id}")]
        public ActionResult<Utilisateur> GetByID(int id)
        {
            Utilisateur user = _FDB.Utilisateurs.Find(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // 
    }
}
