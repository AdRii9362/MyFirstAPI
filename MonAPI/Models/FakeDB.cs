using MonAPI.Interfaces;


namespace MonAPI.Models
{
    public class FakeDB : IFakeDB
    {
        #region Attributs
        private List<Utilisateur> _Utilisateurs; //on crée notre utilisateur
        #endregion

        #region Propriétés

        public FakeDB()
        {
            _Utilisateurs = new List<Utilisateur>()
            {
                new Utilisateur(1,"Jean", new DateTime(1995,05,15)),
                new Utilisateur(2,"Paul", new DateTime(1998,05,15)),
                new Utilisateur(3,"Jack", new DateTime(1999,05,15)),
                new Utilisateur(4,"Yves", new DateTime(1992,05,15)),
            };
        }
        #endregion

        #region Constructeur
        public List<Utilisateur> Utilisateurs
        {
            get { return _Utilisateurs; }
            set { _Utilisateurs = value;}
        }
        #endregion

    }
}
