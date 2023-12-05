

using MonAPI.Models;

namespace MonAPI.Interfaces
{

        public interface IFakeDB
        {
            List<Utilisateur> Utilisateurs { get; set; }
        }

    
}
