namespace TorreDiHanoi
{
    public class TorreDiHanoi
    {
        private Stack<int>[] _torri;
        private int _dischi;
        private int _mosse;
        private int _ultimoDiscoSpostato;
        
        public TorreDiHanoi(int numeroTorri, int numeroDischi)
        {
            _torri = new Stack<int>[numeroTorri];
            _dischi = numeroDischi;
            _mosse = 0;
            for (int i = 0; i < _torri.Length; i++)
            {
                _torri[i] = new Stack<int>();
            }
            for (int i = numeroDischi; i >= 1; i--)
            {
                _torri[0].Push(i);
            }
        }
        
        public void Stampa()
        {
            for (int i = 0; i < _torri.Length; i++)
            {
                Console.Write($"Torre {i + 1}: [");
                var x = _torri[i].ToArray();
                Array.Reverse(x);
                int j = 0;

                foreach (int t in x)
                {
                    Console.Write($"{t}");
                    if (j < x.Length - 1)
                    {
                        Console.Write(", ");
                    }
                    j++;
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }

        public void Sposta(int torreIniziale, int torreFinale)
        {
            if (!VerificaSpostamento(torreIniziale, torreFinale))
            {
                Console.WriteLine("Mossa non valida");
                return;
            }
            var numero = _torri[torreIniziale].Pop();
            _torri[torreFinale].Push(numero);
            _ultimoDiscoSpostato = numero;
            _mosse++;
        }
        
        public bool VerificaSpostamento(int torreIniziale, int torreFinale)
        {
            if (torreIniziale == torreFinale)
            {
                return false;
            }
            if (torreIniziale >= Torri || torreIniziale < 0)
            {
                return false;
            }
            if (torreFinale >= Torri || torreFinale < 0)
            {
                return false;
            }
            if (_torri[torreIniziale].Count() < 1)
            {
                return false;
            }
            if (_torri[torreFinale].Count() == 0)
            {
                return true;
            }
            if (_torri[torreFinale].Peek() < _torri[torreIniziale].Peek())
            {
                return false;
            }
            return true;
        }
        
        public bool VerificaVincita()
        {
            for (int i = 1; i < _torri.Length; i++)
            {
                if (_torri[i].Count() == _dischi)
                {
                    return true;
                }
            }
            return false;
        }
        
        public List<Tuple<int, int>> MosseDisponibili()
        {
            List<Tuple<int, int>> listaMosse = new List<Tuple<int, int>>();
            for (int i = 0; i < _torri.Length; i++)
            {
                for (int j = 0; j < _torri.Length; j++)
                {
                    if (VerificaSpostamento(i, j))
                    {
                        Tuple<int, int> mossa = new Tuple<int, int>(i, j);
                        listaMosse.Add(mossa);
                    }
                }
            }
            return listaMosse;
        }
        
        public int? PeekTorre(int torre)
        {
            if (_torri[torre].Count() == 0)
            {
                return null;
            }
            if (torre >= 0 && torre < _torri.Length)
            {
                return _torri[torre].Peek();
            }
            return null;
        }
        
        public int DischiInTorre(int torre)
        {
            if (torre >= 0 && torre < _torri.Length)
            {
                return _torri[torre].Count();
            }
            return 0;
        }

        public int Dischi => _dischi;
        public int Torri => _torri.Length;
        public int Mosse => _mosse;
        public int MosseMinime() => (int)Math.Pow(2, _dischi) - 1;
        public int UltimoDiscoSpostato => _ultimoDiscoSpostato;
    }

    public class Program
    {
        static void Execute()
        {
            // Gioco Manuale:

            //Console.Write("Inserisci il numero di torri: ");
            //int torri = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input non valido per il numero di torri."));
            //Console.Write("Inserisci il numero dei dischi: ");
            //string? inputDischi = Console.ReadLine();
            //int dischi = int.Parse(inputDischi ?? throw new InvalidOperationException("Input non valido per il numero dei dischi."));
            //TorreDiHanoi gioco = new TorreDiHanoi(torri, dischi);
            //do
            //{
            //    try
            //    {
            //        gioco.Stampa();
            //        Console.Write("Inserisci la torre iniziale: ");
            //        int torreIniziale = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input non valido."));
            //        Console.Write("Inserisci la torre finale: ");
            //        int torreFinale = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input non valido."));
            //        gioco.Sposta(torreIniziale, torreFinale);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Si è verificata un eccezione: " + ex.Message);
            //    }
            //}
            //while (gioco.VerificaVincita() == false);
            //Console.WriteLine("Hai vinto! Hai completato il gioco in " + gioco.Mosse + " mosse.");
            //Console.WriteLine("Il numero minimo di mosse per vincere il gioco è: " + gioco.MosseMinime());

            // Gioco Automatico
            Console.Write("Inserisci il numero di torri: ");
            int torri = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input non valido per il numero di torri."));
            Console.Write("Inserisci il numero dei dischi: ");
            string? inputDischi = Console.ReadLine();
            int dischi = int.Parse(inputDischi ?? throw new InvalidOperationException("Input non valido per il numero dei dischi."));
            TorreDiHanoi giocoAutomatico = new TorreDiHanoi(torri, dischi);
            do
            {
                try
                {
                    giocoAutomatico.Stampa();
                    //Console.WriteLine("Premi un tasto per continuare");
                    //Console.ReadLine();
                    if (giocoAutomatico.Mosse == 0)
                    {
                        if (dischi % 2 == 0)
                        {
                            giocoAutomatico.Sposta(0, 1);
                        }
                        else
                        {
                            giocoAutomatico.Sposta(0, 2);
                        }
                    }
                    else
                    {
                        var mosse = giocoAutomatico.MosseDisponibili();
                        var mosseClone = new List<Tuple<int, int>>();
                        //Console.WriteLine("mosse disponibili");
                        //StampaTupla(mosse);
                        //Console.WriteLine();
                        for (int i = 0; i < mosse.Count; i++)
                        {
                            bool mossaValida = true;
                            int? discoOnTopTorre1 = giocoAutomatico.PeekTorre(mosse[i].Item1);
                            int? discoOnTopTorre2 = giocoAutomatico.PeekTorre(mosse[i].Item2);
                            if (discoOnTopTorre2 != null)
                            {
                                if (discoOnTopTorre1 % 2 == 0 && discoOnTopTorre2 % 2 == 0)
                                {
                                    //Console.WriteLine("Modulo %");
                                    mossaValida = false;
                                }
                                if (discoOnTopTorre1 % 2 != 0 && discoOnTopTorre2 % 2 != 0)
                                {
                                    //Console.WriteLine("Modulo %");
                                    mossaValida = false;
                                }
                            }
                            if (discoOnTopTorre1 == giocoAutomatico.UltimoDiscoSpostato)
                            {
                                mossaValida = false;
                            }
                            if (mossaValida)
                            {
                                mosseClone.Add(mosse[i]);
                            }
                        }
                        //Console.WriteLine("Mosse accettate");
                        //StampaTupla(mosseClone);
                        //Console.WriteLine();
                        if (mosseClone.Count == 1)
                        {
                            giocoAutomatico.Sposta(mosseClone[0].Item1, mosseClone[0].Item2);
                        }
                        else
                        {
                            if (giocoAutomatico.DischiInTorre(mosseClone[0].Item2) > 0)
                            {
                                giocoAutomatico.Sposta(mosseClone[0].Item1, mosseClone[0].Item2);
                            }
                            else
                            {
                                giocoAutomatico.Sposta(mosseClone[1].Item1, mosseClone[1].Item2);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Si è verificata un eccezione: " + ex.Message);
                }
            }
            while (giocoAutomatico.VerificaVincita() == false);
            Console.WriteLine("Hai vinto! Hai completato il gioco in " + giocoAutomatico.Mosse + " mosse.");
            Console.WriteLine("Il numero minimo di mosse per vincere il gioco è: " + giocoAutomatico.MosseMinime());
        }
     
        public static void StampaTupla(List<Tuple<int, int>> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Item1} - {item.Item2}");
            }
        }
    }
}
