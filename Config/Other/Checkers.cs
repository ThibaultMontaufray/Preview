using System.Collections.Generic;
using System.Linq;

namespace GAMES
{
    public class Checkers : Game
    {
        /*
         * RULES
         * 
         * le but du jeu est de tuer tous les pions adverses
         * un pion ne peut qu'avancer et en diagonale
         * si un pion peut sauter un pion adverse il doit le faire
         * un pion arrivant à la ligne du fond devient une dame
         * une dame avance en diagonale d'autant de case qu'elle veut tant qu'elle ne rencontre pas de pion
         * si une dame peut sauter un pion adverse elle doit le faire
         */

        #region Attribute
        private int _hauteur;
        private int _largeur;
        private string[,] _carte;
        private Joueur _joueur_1;
        private Joueur _joueur_2;
        #endregion

        #region Properties
        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        public int Hauteur
        {
            get { return _hauteur; }
            set { _hauteur = value; }
        }
        public string[,] Carte
        {
            get { return _carte; }
        }
        #endregion

        #region Constructor
        public Checkers()
        {
            _largeur = 10;
            _hauteur = 10;
            _carte = new string[_largeur, _hauteur];
            Installer_jeu();
        }
        #endregion

        #region Methods public
        public void Installer_jeu()
        {
            List<Pion> lp;

            _joueur_1 = new Joueur() { Name="O" };
            lp = new List<Pion>();
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 1, Y = 0 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 3, Y = 0 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 5, Y = 0 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 7, Y = 0 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 9, Y = 0 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 0, Y = 1 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 2, Y = 1 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 4, Y = 1 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 6, Y = 1 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 8, Y = 1 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 1, Y = 2 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 3, Y = 2 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 5, Y = 2 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 7, Y = 2 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 9, Y = 2 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 0, Y = 3 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 2, Y = 3 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 4, Y = 3 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 6, Y = 3 }, Direction = Pion.DIRECTION.BAS });
            lp.Add(new Pion() { Name = "pion", Joueur = "X", Emplacement = new Coord() { X = 8, Y = 3 }, Direction = Pion.DIRECTION.BAS });
            _joueur_1.Pions = lp;

            _joueur_2 = new Joueur() { Name = "X" };
            lp = new List<Pion>();
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 1, Y = 6 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 3, Y = 6 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 5, Y = 6 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 7, Y = 6 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 9, Y = 6 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 0, Y = 7 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 2, Y = 7 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 4, Y = 7 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 6, Y = 7 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 8, Y = 7 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 1, Y = 8 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 3, Y = 8 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 5, Y = 8 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 7, Y = 8 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 9, Y = 8 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 0, Y = 9 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 2, Y = 9 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 4, Y = 9 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 6, Y = 9 }, Direction = Pion.DIRECTION.HAUT });
            lp.Add(new Pion() { Name = "pion", Joueur = "O", Emplacement = new Coord() { X = 8, Y = 9 }, Direction = Pion.DIRECTION.HAUT });
            _joueur_2.Pions = lp;
        }
        public void Rafraichir_carte()
        {
            _carte = new string[_hauteur, _largeur];
            foreach (Pion item in _joueur_1.Pions) { _carte[item.Emplacement.X, item.Emplacement.Y] = "X"; }
            foreach (Pion item in _joueur_2.Pions) { _carte[item.Emplacement.X, item.Emplacement.Y] = "O"; }
            foreach (Pion item in _joueur_1.Pions) { item.Plateau = _carte; }
            foreach (Pion item in _joueur_2.Pions) { item.Plateau = _carte; }
        }
        public Pion Selectionner_pion(int x, int y)
        {
            Coord currentCoord = new Coord() { X = x, Y = y };
            foreach (var item in _joueur_1.Pions) { if (item.Emplacement.Equals(currentCoord)) return item; }
            foreach (var item in _joueur_2.Pions) { if (item.Emplacement.Equals(currentCoord)) return item; }
            return new Pion();
        }

        public void ACTION_Deplacer_pion(Pion pion, int x, int y)
        {
            Move(_joueur_1, pion, x, y);
            Move(_joueur_2, pion, x, y);
        }
        public void ACTION_Attaquer_pion(Pion pion, int x, int y)
        {
            Attak(_joueur_1, pion, x, y);
            Attak(_joueur_2, pion, x, y);
        }
        #endregion

        #region Methods private
        private void Move(Joueur j, Pion p, int x, int y)
        {
            int index = -1;
            for (int i = 0; i < j.Pions.Count; i++)
            {
                if (j.Pions[i].Emplacement.Equals(p.Emplacement))
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                j.Pions[index].Emplacement.X = x;
                j.Pions[index].Emplacement.Y = y;
                Rafraichir_carte();
            }
        }
        private void Attak(Joueur j, Pion p, int x, int y)
        {
            int index = -1;
            int killX, killY;

            for (int i = 0; i < j.Pions.Count; i++)
            {
                if (j.Pions[i].Emplacement.Equals(p.Emplacement))
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                killX = j.Pions[index].Emplacement.X - x > 0 ? 1 : -1;
                killY = j.Pions[index].Emplacement.Y - y > 0 ? 1 : -1;

                j.Pions[index].Emplacement.X = x;
                j.Pions[index].Emplacement.Y = y;
                Rafraichir_carte();

                if (j.Equals(_joueur_1)) _joueur_2.Pions.Remove(Selectionner_pion(j.Pions[index].Emplacement.X + killX, j.Pions[index].Emplacement.Y + killY));
                else _joueur_1.Pions.Remove(Selectionner_pion(j.Pions[index].Emplacement.X + killX, j.Pions[index].Emplacement.Y + killY));
            }
        }
        #endregion
    }

    public class Joueur
    {
        public List<Pion> Pions;
        public string Name;
    }

    public class Pion
    {
        public enum DIRECTION
        {
            HAUT,
            BAS
        }
        public enum TYPE
        {
            DEPLACEMENT = 1,
            ATTAQUE = 2
        }
        public string Joueur;
        public string Name;
        public Coord Emplacement;
        public DIRECTION Direction;
        public string[,] Plateau;
        public List<Dictionary<string, int>> Mouvement
        {
            get
            {
                Dictionary<string, int> dico;
                List<Dictionary<string, int>> ldic = new List<Dictionary<string, int>>();

                dico = new Dictionary<string, int>();
                dico["x"] = +2;
                dico["y"] = +2;
                dico["type"] = (int)TYPE.ATTAQUE;
                ldic.Add(dico);

                dico = new Dictionary<string, int>();
                dico["x"] = +2;
                dico["y"] = -2;
                dico["type"] = (int)TYPE.ATTAQUE;
                ldic.Add(dico);

                dico = new Dictionary<string, int>();
                dico["x"] = -2;
                dico["y"] = -2;
                dico["type"] = (int)TYPE.ATTAQUE;
                ldic.Add(dico);

                dico = new Dictionary<string, int>();
                dico["x"] = -2;
                dico["y"] = +2;
                dico["type"] = (int)TYPE.ATTAQUE;
                ldic.Add(dico);

                dico = new Dictionary<string, int>();
                dico["x"] = +1;
                dico["y"] = Direction.Equals(DIRECTION.HAUT) ? -1 : 1;
                dico["type"] = (int)TYPE.DEPLACEMENT;
                ldic.Add(dico);

                dico = new Dictionary<string, int>();
                dico["x"] = -1;
                dico["y"] = Direction.Equals(DIRECTION.HAUT) ? -1 : 1;
                dico["type"] = (int)TYPE.DEPLACEMENT;
                ldic.Add(dico);

                return ldic;
            }
        }
        public List<Dictionary<string, int>> Deplacements
        {
            get
            {
                List<Dictionary<string, int>> ldic = new List<Dictionary<string, int>>();
                if (Plateau != null)
                {
                    string cell;
                    Dictionary<string, int> dico;
                    foreach (var item in Mouvement)
                    {
                        if (!Sortie_de_plateau(Emplacement.X + item["x"], Emplacement.Y + item["y"]))
                        {
                            cell = Plateau[Emplacement.X + item["x"], Emplacement.Y + item["y"]];
                            if (string.IsNullOrEmpty(cell))
                            {
                                if (item["type"].Equals((int)TYPE.DEPLACEMENT))
                                {
                                    if (string.IsNullOrEmpty(cell))
                                    {
                                        dico = new Dictionary<string, int>();
                                        dico["x"] = Emplacement.X + item["x"];
                                        dico["y"] = Emplacement.Y + item["y"];
                                        dico["type"] = (int)TYPE.DEPLACEMENT;
                                        ldic.Add(dico);
                                    }
                                }
                                else
                                {
                                    cell = Plateau[Emplacement.X + (item["x"] / 2), Emplacement.Y + (item["y"] / 2)];
                                    if (!string.IsNullOrEmpty(cell) && !cell.Equals(Joueur))
                                    {
                                        dico = new Dictionary<string, int>();
                                        dico["x"] = Emplacement.X + item["x"];
                                        dico["y"] = Emplacement.Y + item["y"];
                                        dico["type"] = (int)TYPE.ATTAQUE;
                                        ldic.Add(dico);
                                    }
                                }
                            }
                        }
                    }
                    if (ldic.Where(i => i["type"].Equals((int)TYPE.ATTAQUE)).ToList().Count > 0) ldic.RemoveAll(i => !i["type"].Equals((int)TYPE.ATTAQUE));
                }
                return ldic;
            }
        }

        private bool Sortie_de_plateau(int x, int y)
        {
            return !(x >= 0 && x < 10 && y >= 0 && y < 10);
        }
    }

    public struct Coord
    {
        public int X;
        public int Y;
    }
}
