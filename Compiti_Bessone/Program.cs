using System;
using System.Drawing;

namespace Compiti_Bessone
{
    enum GiorniDellaSettimana 
    { 
        Lunedi, 
        Martedi, 
        Mercoledi, 
        Giovedi, 
        Venerdi, 
        Sabato, 
        Domenica 
    }

    enum LivelliDiPriorita 
    { 
        Bassa, 
        Media, 
        Alta, 
        Critica 
    }

    struct Punto2D 
    { 
        public readonly double X { get; } 
        public readonly double Y { get; } 
        public Punto2D(double x, double y) 
        { 
            X = x;
            Y = y; 
        } 
        public double CalcolaDistanza(Punto2D altroPunto) 
        { 
            double aX = altroPunto.X - X; 
            double aY = altroPunto.Y - Y; 
            return Math.Sqrt(aX * aX + aY * aY); 
        } 
    }

    struct Rettangolo 
    { 
        public double Base { get; set; } 
        public double Altezza { get; set; } 
        public Rettangolo(double abase, double altezza) 
        { 
            Base = abase; 
            Altezza = altezza; 
        } 
        public double CalcolaArea() 
        { 
            return Base * Altezza; 
        } 
    }

    enum TipoVeicolo 
    { 
        Auto = 1, 
        Moto = 2, 
        Camion = 3, 
        Autobus = 4 
    }

    struct ColoreRGB 
    { 
        public int Rosso { get; set; } 
        public int Verde { get; set; } 
        public int Blu { get; set; } 
        public ColoreRGB(int rosso, int verde, int blu) 
        { 
            Rosso = rosso; 
            Verde = verde; 
            Blu = blu; 
        } 
        public string Stringa() 
        { 
            return $"RGB(" + Rosso + ", " + Verde + ", " + Blu + ")"; 
        } 
    }

    enum Mesi
    { 
        Gennaio, 
        Febbraio, 
        Marzo, 
        Aprile, 
        Maggio, 
        Giugno, 
        Luglio, 
        Agosto, 
        Settembre, 
        Ottobre, 
        Novembre, 
        Dicembre 
    }

    struct Persona1
    { 
        public string Nome { get; set; } 
        public int Eta { get; set; } 
        public Persona1(string nome, int eta) 
        { 
            Nome = nome; 
            Eta = eta; 
        } 
        public string Stringa() 
        { 
            return "Nome: "+Nome+", Età: "+Eta; 
        } 
    }

    enum TipoErrore 
    { 
        Nessuno, 
        Connessione, 
        Input, 
        Sistema,    
    }

    struct Posizione3D 
    { 
        public double X { get; set; } 
        public double Y { get; set; } 
        public double Z { get; set; } 
        public Posizione3D(double x, double y, double z) 
        { 
            X = x; 
            Y = y; 
            Z = z; 
        } 
        public double Distanza(Posizione3D altraPosizione) 
        { 
            double aX = altraPosizione.X - X; 
            double aY = altraPosizione.Y - Y; 
            double aZ = altraPosizione.Z - Z; 
            return Math.Sqrt(aX * aX + aY * aY + aZ * aZ); 
        } 
    }

    enum Permesso 
    { 
        Osservatore, 
        Lavoratore,
        Amministratore
    }

    struct Data
    { 
        public int Giorno { get; set; } 
        public int Mese { get; set; } 
        public int Anno { get; set; } 
        public Data(int giorno, int mese, int anno) 
        { 
            Giorno = giorno; 
            Mese = mese; 
            Anno = anno; 
        } 
        public string Stringa() 
        { 
            return "Data:" + Giorno+"/"+Mese+"/"+Anno; 
        } 
    }

    struct Carta 
    { public string Valore { get; set; } 
        public string Seme { get; set; } 
        public Carta(string valore, string seme) 
        { 
            Valore = valore; 
            Seme = seme; 
        } 
        public string Stringa() 
        { 
            return Valore+" di " +Seme; 
        }
    }

    struct ContArray 
    { 
        public int[] Numeri { get; set; } 
        public ContArray(int[] numeri) 
        { 
            Numeri = numeri; 
        }  
    }

    enum TipoFile 
    { 
        Documento, 
        Immagine, 
        Video, 
        Audio
    }

    struct Vettore 
    { 
        public double X { get; set; } 
        public double Y { get; set; } 
        public double Z { get; set; } 
        public Vettore(double x, double y, double z) 
        { 
            X = x; Y = y; Z = z; 
        } 
        public double ProdottoScalare(Vettore altroVettore) 
        { 
            return X * altroVettore.X + Y * altroVettore.Y + Z * altroVettore.Z; 
        } 
    }

    static class Compiti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VARIABILI\n");
            Console.WriteLine("Dichiarare una variabile di tipo int e assegnarle un valore, quindi modificarlo.");
            int a = 0;
            Console.WriteLine(a);
            a = 1;
            Console.WriteLine(a + "\n");

            Console.WriteLine("Creare una variabile di tipo string, assegnarle un valore e concatenarla con un'altra stringa.");
            string b = "Buon ";
            Console.WriteLine(b);
            string c = "giorno";
            b = b + c;
            Console.WriteLine(b + "\n");

            Console.WriteLine("Dichiarare una variabile di tipo bool e cambiarne il valore.");
            bool d = true;
            Console.WriteLine(d);
            d = false;
            Console.WriteLine(d + "\n");

            Console.WriteLine("Utilizzare una variabile di tipo double per rappresentare un numero con decimali.");
            double e = 12.34;
            Console.WriteLine(e + "\n");

            Console.WriteLine("Dichiarare una variabile char e assegnarle un carattere.");
            char f = Convert.ToChar("g");
            Console.WriteLine(f + "\n");

            Console.WriteLine("Usare una variabile di tipo decimal per rappresentare una quantità monetaria.");
            decimal g = 12.50m;
            Console.WriteLine(g + "€\n");

            Console.WriteLine("Dichiarare una variabile float e assegnarle un valore, verificandone la precisione rispetto a double.");
            float h = 13.65f;
            Console.WriteLine(h + "\n");

            Console.WriteLine("Dichiarare una variabile long per rappresentare un numero molto grande.");
            long i = 123456789;
            Console.WriteLine(i + "\n");

            Console.WriteLine("Creare una variabile short e verificare il suo range di valori.");
            short j = 32000;
            Console.WriteLine(j + "");
            Console.WriteLine("Il valore minimo che può contenere una variabile short: " + short.MinValue);
            Console.WriteLine("Il valore massimo che può contenere una variabile short: "+short.MaxValue +"\n");

            Console.WriteLine("Usare una variabile byte per rappresentare un numero tra 0 e 255.");
            byte k = 69;
            Console.WriteLine(k + "\n");

            Console.WriteLine("Dichiarare una variabile const e provare a modificarne il valore.");
            const int l = 420;
            Console.WriteLine(l + "\n");
            try { /*l = 100;*/ } catch { Console.WriteLine("Errore: una variabile const non può essere modificata dopo l'assegnazione."); }

            Console.WriteLine("Dichiarare più variabili in una sola riga e assegnare loro valori diversi.");
            int m = 1, n = 2, o = 3;
            Console.WriteLine(m + " " + n + " " + o + "\n");

            Console.WriteLine("Dichiarare una variabile di tipo var e verificare come il compilatore determina il tipo.");
            var p = 104;
            var q = "Circe";
            var r = 3.14;
            var s = true;
            Console.WriteLine(p + " " + q + " " + r + " " + s + "\n");

            Console.WriteLine("Dichiarare e usare variabili con valori predefiniti.\n");
            int t=1;
            float u=2;
            char v=Convert.ToChar("a");
            Console.WriteLine(t + " " + u + " " + v + "\n"); 

            Console.WriteLine("Cambiare il tipo di una variabile usando il casting esplicito.");
            double w = 4.20;
            int x = (int)w;
            Console.WriteLine(w + " " + x + "\n");

            Console.WriteLine("Dichiarare una variabile costante di tipo string.");
            const string y = "Epic: The Musical";
            Console.WriteLine(y + "\n");

            Console.WriteLine("Utilizzare una variabile per rappresentare una data usando il tipo DateTime.");
            DateTime z = new DateTime(2001, 9, 11);
            Console.WriteLine(Convert.ToString(z) + "\n");

            Console.WriteLine("Dichiarare una variabile e utilizzarla in un'espressione matematica.");
            int aa = 1, ab = 2;
            aa = aa + ab;
            Console.WriteLine(aa + "\n\n");

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            Console.WriteLine("FUNZIONI\n");
            Console.WriteLine("Dichiarare una funzione che restituisce un valore di tipo int e accetta due parametri.");
            int ac = A(1, 2);
            Console.WriteLine(ac + "\n");

            Console.WriteLine("Creare una funzione void che stampa un messaggio a console.");
            B();

            Console.WriteLine("Scrivere una funzione che accetta un parametro string e restituisce la lunghezza della stringa.");
            int ad = C("Ares");
            Console.WriteLine(ad + "\n");

            Console.WriteLine("Dichiarare una funzione con un parametro opzionale.");
            D();

            Console.WriteLine("Scrivere una funzione che accetta un array come parametro.");
            int[] ae = { 1, 2 };
            E(ae);

            Console.WriteLine("Scrivere una funzione che calcola il fattoriale di un numero.");
            F();

            Console.WriteLine("Dichiarare una funzione che restituisce un valore di tipo bool basato su una condizione.");
            bool af = G(5);
            if (af)
                Console.WriteLine("Pari\n");
            else
                Console.WriteLine("Dispari\n");

            Console.WriteLine("Creare una funzione che utilizza un'eccezione per gestire input non validi. (try - catch)");
            H();

            Console.WriteLine("Dichiarare una funzione che restituisce una lista di numeri.");
            List<int> lista = I();
            for (i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[Convert.ToInt32(i)]);
            }
            Console.WriteLine();

            Console.WriteLine("Scrivere una funzione che accetta e restituisce oggetti di una classe custom.\n");
            Custom custom = new Custom();
            J(custom);

            Console.WriteLine("Scrivere una funzione che modifica una lista passata come parametro.\n");
            List<int> ag = new List<int>();
            K(ag);

            Console.WriteLine("Creare una funzione che utilizza un'espressione condizionale per determinare il valore restituito. (if else)");
            af = G(4);
            if (af)
                Console.WriteLine("Pari\n");
            else
                Console.WriteLine("Dispari\n");

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J"); //mi serviva per aggiustare il clear che non si stava comportando correttamente

            Console.WriteLine("ALGEBRA DI BOOL");
            Console.WriteLine("Utilizzare un if-else per verificare se un numero è pari o dispari.");
            Console.WriteLine("Già fatto in precedenza\n");

            Console.WriteLine("Scrivere un programma che utilizza una serie di if-else per categorizzare un'età.");

            Console.WriteLine("Creare un'espressione logica che combina più condizioni con &&.");
            bool ai = true, ah = true;
            if ((ai) && (ah))
                Console.WriteLine("Fatto\n");

            Console.WriteLine("Utilizzare un'espressione logica con || per verificare se un numero è compreso in un intervallo.");
            int aj = 15;
            if (!(aj > 20) || !(aj < 10))
            {
                Console.WriteLine("Il numero è compreso tra 10 e 20. Numero: " + aj + "\n");
            }

            Console.WriteLine("Scrivere un if-else che utilizza l'operatore ! per invertire una condizione.");
            Console.WriteLine("Usata in quella precedente\n");

            Console.WriteLine("Dichiarare una variabile booleana e usarla in un'istruzione if.");
            Console.WriteLine("Fatto più volte durante il compito\n");

            Console.WriteLine("Creare un programma che utilizza if-else nidificati.");
            if (ai)
            {
                if (ah)
                    Console.WriteLine("Fatto\n");
            }

            Console.WriteLine("Utilizzare un'espressione switch per valutare un valore booleano.");
            switch (ah)
            {
                case true:
                    Console.WriteLine("Fatto, anche se per i bool è più ottimale un if\n");
                    break;

                case false:
                    Console.WriteLine("Fatto, anche se per i bool è più ottimale un if\n");
                    break;
            }


            Console.WriteLine("Creare un'istruzione if-else che utilizza un'espressione con operatori di confronto.");
            int ak = 10; int al = 20;
            if (ak > al)
                Console.WriteLine("ak è maggiore di al.\n");
            else
                Console.WriteLine("ak è minore o uguale a al.\n");

            Console.WriteLine("Utilizzare un operatore ternario per assegnare un valore a una variabile.");
            int maggiore = (ak > al) ? ak : al;
            Console.WriteLine("Il valore maggiore è: " + maggiore + "\n");

            Console.WriteLine("Scrivere una serie di if-else per verificare più condizioni.");
            int eta = 25;
            if (eta < 25)
                Console.WriteLine("Sei giovane.\n");
            else if (eta < 65)
                Console.WriteLine("Sei adulto.\n");
            else
                Console.WriteLine("Sei anziano.\n");

            Console.WriteLine("Creare un programma che utilizza un if-else per determinare il maggiore tra due numeri.");
            Console.WriteLine("Fatto in precedenza\n");

            Console.WriteLine("Utilizzare un'istruzione if per verificare se una stringa è vuota o nulla.");
            string am = "";
            if (string.IsNullOrEmpty(am))
                Console.WriteLine("La stringa è vuota o nulla.\n");
            else
                Console.WriteLine("La stringa contiene: " + am + "\n");

            Console.WriteLine("Creare un programma che utilizza if-else per verificare se un anno è bisestile.");
            int anno = 2024;
            if (anno % 4 == 0 && (anno % 100 != 0 || anno % 400 == 0))
                Console.WriteLine("L'anno " + anno + " è bisestile.\n");
            else
                Console.WriteLine("L'anno " + anno + " non è bisestile.\n");

            Console.WriteLine("Scrivere un'espressione logica che verifica se una stringa contiene una sottostringa specifica.");
            string an = "Epic: the musical", ao = "Epic";
            if (an.Contains(ao))
                Console.WriteLine("La stringa contiene la sottostringa \"" + ao + "\".\n");
            else
                Console.WriteLine("La stringa non contiene la sottostringa \"" + ao + "\".\n");

            Console.WriteLine("Utilizzare un if-else per verificare se un array contiene un elemento specifico.");
            int[] ap = { 1, 2, 3, 4, 5 };
            int elementoDaVerificare = 3;
            bool contieneElemento = false;
            foreach (int elemento in ap)
            {
                if (elemento == elementoDaVerificare)
                { contieneElemento = true; break; }
            }
            if (contieneElemento)
                Console.WriteLine("L'array contiene l'elemento " + elementoDaVerificare + ".\n");
            else
                Console.WriteLine("L'array non contiene l'elemento " + elementoDaVerificare + ".\n");


            Console.WriteLine("Creare una funzione che utilizza if-else per determinare se un numero è positivo, negativo o zero:");
            int aq = 5;
            string risultato = M(aq);
            Console.WriteLine("Il numero " + aq + " è " + risultato + ".\n");

            Console.WriteLine("Creare un programma che utilizza un switch per determinare il giorno della settimana.");
            int giornoSettimana = 3;
            switch (giornoSettimana)
            {
                case 1:
                    Console.WriteLine("Lunedì\n");
                    break;
                case 2:
                    Console.WriteLine("Martedì\n");
                    break;
                case 3:
                    Console.WriteLine("Mercoledì\n");
                    break;
                case 4:
                    Console.WriteLine("Giovedì\n");
                    break;
                case 5:
                    Console.WriteLine("Venerdì\n");
                    break;
                case 6:
                    Console.WriteLine("Sabato\n");
                    break;
                case 7:
                    Console.WriteLine("Domenica\n");
                    break;
                default:
                    Console.WriteLine("Giorno non valido\n");
                    break;
            }

            Console.WriteLine("Utilizzare un'istruzione if per verificare se un numero è divisibile per 3 e 5.");
            int ar = 15;
            if (ar % 3 == 0 && ar % 5 == 0)
                Console.WriteLine("Il numero " + ar + " è divisibile per 3 e 5.\n");
            else
                Console.WriteLine("Il numero " + ar + " non è divisibile per 3 e 5.\n");

            Console.WriteLine("Scrivere un'istruzione if per verificare se un valore booleano è true.");
            bool at = true;
            if (at)
                Console.WriteLine("Il valore booleano è true.\n");
            else
                Console.WriteLine("Il valore booleano è false.\n");

            Console.WriteLine("Utilizzare un switch per valutare una variabile stringa.");
            string au = "Circe";
            switch (au)
            {
                case "Circe":
                    Console.WriteLine("Il personaggio è Circe\n");
                    break;
                case "Penelope":
                    Console.WriteLine("Il personaggio è Penelope.\n");
                    break;
                case "Calipso":
                    Console.WriteLine("Il persenoggio è Calipso.\n");
                    break;
                default:
                    Console.WriteLine("Personaggio non valido.\n");
                    break;
            }

            Console.WriteLine("Creare un programma che utilizza un if per verificare se un array è vuoto.");
            int[] av = { };
            if (av.Length == 0)
                Console.WriteLine("L'array è vuoto.\n");
            else
                Console.WriteLine("L'array non è vuoto.\n");

            Console.WriteLine("Utilizzare un if per verificare se un valore è un numero primo.");
            int aw = 7;
            if (IsPrime(aw))
                Console.WriteLine("Il numero " + aw + " è primo.\n");
            else
                Console.WriteLine("Il numero " + aw + " non è primo.\n");

            Console.WriteLine("Scrivere un programma che utilizza un'istruzione if-else per verificare se una parola è palindroma.");
            string ax = "otto";
            if (IsPalindrome(ax))
                Console.WriteLine("La parola \"" + ax + "\" è palindroma.\n");
            else
                Console.WriteLine("La parola \"" + ax + "\" non è palindroma.\n");

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            Console.WriteLine("LOOP");

            Console.WriteLine("Scrivere un ciclo for che stampa numeri da 1 a 10.");
            for (int i1 = 1; i1 <= 10; i1++)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine();

            Console.WriteLine("Creare un ciclo while che continua finché un valore è minore di 100.");
            int ay = 0; while (ay < 100)
            {
                Console.WriteLine(ay);
                ay += 25;
            }
            Console.WriteLine();

            Console.WriteLine("Utilizzare un ciclo do-while per chiedere all'utente di inserire un valore valido.");
            int az = 0;
            do
            {
                Console.WriteLine("Inserisci un numero tra 1 e 10:");
                try
                {
                    string input = Console.ReadLine();
                    az = Convert.ToInt32(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("riprova");
                }
            } while (az < 1 || az > 10);
            Console.WriteLine("Hai inserito un valore valido: " + az);

            Console.WriteLine("Scrivere un ciclo for che calcola la somma di un array.");
            int[] ba = { 1, 2, 3, 4, 5 };
            int somma = 0;
            for (int i1 = 0; i1 < ba.Length; i1++)
            {
                somma += ba[i];
            }
            Console.WriteLine("La somma degli elementi dell'array è: " + somma + "\n");

            Console.WriteLine("Utilizzare un ciclo foreach per iterare attraverso una lista di stringhe.");
            List<string> bb = new List<string> { "Jorge", "Rivera", "-", "Herrans" };
            foreach (string parola in bb)
            {
                Console.WriteLine(parola);
            }
            Console.WriteLine();


            Console.WriteLine("Creare un ciclo for che calcola il fattoriale di un numero.");
            Console.WriteLine("Fatto in precedenza\n");

            Console.WriteLine("Scrivere un ciclo while che verifica se un numero è primo.");
            Console.WriteLine("Fatto in precedenza\n");

            Console.WriteLine("Utilizzare un ciclo do-while per stampare i numeri pari fino a un massimo.");
            int bc = 0;
            int massimo = 20;
            do
            {
                if (bc % 2 == 0)
                {
                    Console.WriteLine(bc);
                }
                bc++;
            } while (bc <= massimo);
            Console.WriteLine();

            Console.WriteLine("Scrivere un ciclo for che stampa i numeri in ordine inverso.");
            for (int i1 = 10; i1 >= 1; i1--)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine();

            Console.WriteLine("Creare un ciclo while che calcola il prodotto dei numeri fino a un valore specifico.");
            int bd = 5;
            int be = 1;
            long prodotto = 1;
            while (be <= bd)
            {
                prodotto *= i;
                be++;
            }
            Console.WriteLine("Il prodotto dei numeri da 1 a " + bd + " è: " + prodotto + "\n");

            Console.WriteLine("Utilizzare un ciclo foreach per modificare i valori in una lista.");
            List<int> bf = new List<int> { 1, 2, 3, 4, 5 };
            for (int i1 = 0; i1 < bf.Count; i1++)
            {
                bf[i1] *= 2;
            }
            foreach (int numero in bf)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine();

            Console.WriteLine("Scrivere un ciclo do-while che calcola il totale di un array.");
            int[] bg = { 1, 2, 3, 4, 5 };
            int totale = 0;
            int bh = 0;
            do
            {
                totale += bg[bh];
                bh++;
            } while (bh < bg.Length);
            Console.WriteLine("Il totale degli elementi dell'array è: " + totale + "\n");

            Console.WriteLine("Creare un ciclo for che utilizza un'istruzione break.");
            for (int i1 = 1; i1 <= 10; i1++)
            {
                if (i1 == 5)
                {
                    Console.WriteLine("Interruzione del ciclo al valore " + i1);
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Utilizzare un ciclo while che termina con un'istruzione continue.");
            int bi = 0;
            int bj = 10; while (bi <= bj)
            {
                bi++;
                if (bi % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(bi);
            }
            Console.WriteLine();

            Console.WriteLine("Scrivere un ciclo for che utilizza una variabile dichiarata all'esterno del ciclo.");
            Console.WriteLine("Fatto più volte in precedenza\n");

            Console.WriteLine("Creare un ciclo foreach che stampa gli indici e i valori di un array.");
            int[] bk = { 10, 20, 30, 40, 50 };
            int bl = 0;
            foreach (int elemento in bk)
            {
                Console.WriteLine("Indice: " + bl + ", Valore: " + bk);
                bl++;
            }
            Console.WriteLine();

            Console.WriteLine("Utilizzare un ciclo do-while che verifica un valore booleano prima di continuare.");
            bool continua = true; int contatore = 0; do
            {
                if (!continua) { break; }
                contatore++; Console.WriteLine("Contatore: " + contatore); if (contatore >= 5) { continua = false; }
            } while (continua); Console.WriteLine("Il ciclo è terminato.\n");

            Console.WriteLine("Scrivere un ciclo for che calcola la somma dei numeri dispari.");
            int bm = 0;
            for (int i1 = 1; i1 <= 10; i1++)
            {
                if (i1 % 2 != 0)
                { bm += i1; }
            }
            Console.WriteLine("La somma dei numeri dispari da 1 a 10 è: " + bm + "\n");

            Console.WriteLine("Creare un ciclo while che termina quando un valore raggiunge una soglia.");
            int bn = 0;
            int soglia = 50;
            while (bn < soglia)
            {
                Console.WriteLine("Valore corrente: " + bn);
                bn += 5;
            }
            Console.WriteLine("Il ciclo è terminato perché il valore ha raggiunto la soglia di " + soglia + ".\n");

            Console.WriteLine("Utilizzare un ciclo foreach per calcolare la lunghezza totale di tutte le stringhe in una lista.");
            int bo = 0;
            foreach (string parola in bb)
            { bo += parola.Length; }
            Console.WriteLine("La lunghezza totale di tutte le stringhe nella lista è: " + bo + "\n");

            Console.WriteLine("Scrivere un ciclo do-while che stampa un menu fino a quando l'utente sceglie di uscire.");
            bool bp = true;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Opzione 1");
                Console.WriteLine("2. Opzione 2");
                Console.WriteLine("3. Esci");
                Console.Write("Scegli un'opzione: ");
                try
                {
                    string scelta = Console.ReadLine();
                    switch (scelta)
                    {
                        case "1":
                            Console.WriteLine("Hai scelto l'Opzione 1.\n");
                            break;
                        case "2":
                            Console.WriteLine("Hai scelto l'Opzione 2.\n");
                            break;
                        case "3":
                            bp = false;
                            Console.WriteLine("Uscita dal menu.\n");
                            break;
                        default:
                            Console.WriteLine("Opzione non valida. Riprova.\n");
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("Riprova"); }
            } while (bp);
            Console.WriteLine("Il ciclo è terminato.\n");

            Console.WriteLine("Creare un ciclo for che utilizza una condizione complessa.");
            for (int i1 = 0; i1 <= 100; i1++)
            {
                if ((i1 % 2 == 0 && i1 > 75) || (i % 2 == 0 && i < 25))
                {
                    Console.WriteLine(i1);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Utilizzare un ciclo while per cercare un valore specifico in un array.");
            int[] bq = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int valoreCercato = 7;
            int br = 0;
            bool trovato = false;
            while (br < bq.Length)
            {
                if (bq[br] == valoreCercato)
                {
                    trovato = true;
                    break;
                }
                br++;
            }
            if (trovato)
            {
                Console.WriteLine("Il valore " + valoreCercato + " è stato trovato nell'array all'indice " + br + ".\n");
            }
            else
            {
                Console.WriteLine("Il valore " + valoreCercato + " non è stato trovato nell'array.\n");
            }

            Console.WriteLine("Scrivere un ciclo for che calcola la media di un array.");
            int[] bs = { 10, 20, 30, 40, 50 };
            int bssomma = 0;
            for (int i1 = 0; i1 < bs.Length; i1++)
            {
                bssomma += bs[i1];
            }
            double media = bssomma / bs.Length;
            Console.WriteLine("La media degli elementi dell'array è: " + media + "\n");

            Console.WriteLine("Creare un ciclo foreach che copia valori da un array a un altro.");
            int[] bt = { 1, 2, 3, 4, 5 }; 
            int[] btCopia = new int[bt.Length]; 
            int indice = 0; 
            foreach (int valore in bt) 
            { 
                btCopia[indice] = valore; indice++; 
            }
            Console.WriteLine("Array originale: "); 
            foreach (int valore in bt) 
            { 
                Console.Write(valore + " "); 
            }
            Console.WriteLine();
            Console.WriteLine("Array copia: ");
            foreach (int valore in btCopia) 
            { 
                Console.Write(valore + " "); 
            }
            Console.WriteLine();

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            Console.WriteLine("ENUM, STRUCT e CAST");
            Console.WriteLine("Creare un enum per rappresentare i giorni della settimana e iterare sui valori.");
            foreach (GiorniDellaSettimana giorno in Enum.GetValues(typeof(GiorniDellaSettimana))) 
            { 
                Console.WriteLine(giorno); 
            }
            Console.WriteLine();

            Console.WriteLine("Dichiarare un enum per rappresentare i livelli di priorità di un task.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Usare un enum per selezionare un'opzione in uno switch-case.");
            LivelliDiPriorita priorita = LivelliDiPriorita.Media;
            switch (priorita) 
            { 
                case LivelliDiPriorita.Alta: Console.WriteLine("Alta"); 
                    break; 
                case LivelliDiPriorita.Media: Console.WriteLine("Media"); 
                    break; 
                case LivelliDiPriorita.Bassa: Console.WriteLine("Bassa"); 
                    break;
                case LivelliDiPriorita.Critica: Console.WriteLine("Critica");
                    break;
                default: Console.WriteLine("Opzione non valida."); 
                    break; 
            }

            Console.WriteLine("Dichiarare una struct per rappresentare un punto 2D e calcolare la distanza tra due punti.");
            Punto2D punto1 = new Punto2D(3, 4); Punto2D punto2 = new Punto2D(7, 1); double distanza = punto1.CalcolaDistanza(punto2); Console.WriteLine("La distanza tra i due punti è: " + distanza);

            Console.WriteLine("Creare una struct per rappresentare un rettangolo e calcolarne l'area.");
            Rettangolo rettangolo = new Rettangolo(5, 10); double area = rettangolo.CalcolaArea(); Console.WriteLine("L'area del rettangolo è: " + area);

            Console.WriteLine("Utilizzare un enum per rappresentare i tipi di un veicolo in un programma.");
            Console.WriteLine("Fatto");

            Console.WriteLine("Dichiarare una struct con un costruttore e un metodo.");
            Console.WriteLine("Fatto in precedenza\n");

            Console.WriteLine("Scrivere un programma che converte un valore int in un enum usando il casting.");
            int val = 2; 
            TipoVeicolo veicolo = (TipoVeicolo)val; 
            Console.WriteLine("Il valore intero " + val + " corrisponde al veicolo " + veicolo + ".\n");

            Console.WriteLine("Dichiarare un enum con valori personalizzati e verificarne l'uso.");
            val++;
            Console.WriteLine("Il valore intero " + val + " corrisponde al veicolo " + veicolo + ".\n");

            Console.WriteLine("Creare una struct per rappresentare un colore in formato RGB.");
            ColoreRGB colore = new ColoreRGB(0, 0, 0); 
            Console.WriteLine("Il colore in formato RGB è: " + colore.Stringa() + "\n"); 

            Console.WriteLine("Utilizzare un enum in una funzione per selezionare un'opzione.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una struct con proprietà readonly.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare un enum per rappresentare i mesi dell'anno.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una struct per rappresentare una persona con nome e età.");
            Persona1 persona = new Persona1("Mario Rossi", 30); 
            Console.WriteLine("La persona è: " + persona.Stringa()); 
            Console.WriteLine();

            Console.WriteLine("Scrivere un programma che utilizza il casting esplicito tra tipi numerici.");
            Console.WriteLine("Viene fatto dopo\n");


            Console.WriteLine("Dichiarare un enum per rappresentare i tipi di errore di un'app.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una struct per rappresentare una posizione 3D e calcolarne la distanza.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Utilizzare un enum per definire i tipi di permesso di un'app.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una struct per rappresentare una data personalizzata.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una struct per rappresentare una carta da gioco (valore e seme).");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Utilizzare un enum in un'istruzione condizionale.");
            if(veicolo == TipoVeicolo.Autobus)
            {
                Console.WriteLine(veicolo + "\n");
            }

            Console.WriteLine("Dichiarare una struct che contiene un array come proprietà.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Scrivere un programma che converte un valore double in float usando il casting esplicito.");
            double numeroDouble = 123.456; 
            float numeroFloat = (float)numeroDouble; 
            Console.WriteLine($"Valore originale double: " + numeroDouble +  ", trasformato in float:" + numeroFloat+"\n"); 

            Console.WriteLine("Utilizzare un enum per rappresentare i tipi di file supportati da un'app.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una struct per rappresentare un vettore e calcolare il prodotto scalare.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            Console.WriteLine("ARRAY e LISTE");
            Console.WriteLine("Creare un array di int con 5 elementi e stamparne i valori.");
            Console.WriteLine("Fatto diverse volte in precedenza\n");

            Console.WriteLine("Dichiarare una lista di stringhe e aggiungere elementi dinamicamente.");
            bb.Add("Epic");


            Console.WriteLine("Creare un array bidimensionale e popolarlo con valori. ([,])");
            int[,] arrayBi = new int[3, 3]; 
            for (int i1 = 0; i1 < 3; i1++) 
            { 
                for (int j1 = 0; j1 < 3; j1++) 
                {
                    arrayBi[i1, j1] = j1+i1; 
                } 
            }

            Console.WriteLine("Utilizzare un array per calcolare la media dei valori.");
            Console.WriteLine("Fatto in precedenza");

            Console.WriteLine("Dichiarare una lista di oggetti personalizzati. (classi, enum, struct, ecc)");
            List<TipoVeicolo> veicoli = new List<TipoVeicolo>();
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare un array di booleani per rappresentare lo stato di vari interruttori.");
            bool[] stato = { true, false, false, false, true };
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una lista di numeri e ordinarla.");
            List<int> numeri = new List<int> { 5, 3, 8, 1, 2 }; 
            numeri.Sort(); 
            Console.WriteLine("Lista di numeri ordinata:"); 
            foreach (int numero in numeri)
            { 
                Console.WriteLine(numero); 
            } 
            Console.WriteLine();

            Console.WriteLine("Utilizzare un array per contare la frequenza di un valore.");
            int[] numeri2 = { 1, 2, 2, 3, 4, 4, 4, 5 }; 
            int frequenza = 0; 
            foreach (int numero in numeri2) 
            { 
                if (numero == 4) 
                { 
                    frequenza++; 
                } 
            } 
            Console.WriteLine("La frequenza del valore 4 nell'array è: " + frequenza + "\n");

            Console.WriteLine("Creare una lista di stringhe e rimuovere elementi specifici.");
            List<string> personaggi = new List<string> { "Mel", "Jinx", "Vi", "Caitlyn", "Ekko" }; 
            personaggi.RemoveAll(a => a == "Jinx");  
            Console.WriteLine("Lista di personaggi dopo la rimozione di Jinx"); 
            foreach (string pers in personaggi) 
            { 
                Console.WriteLine(pers); 
            } 
            Console.WriteLine();

            Console.WriteLine("Dichiarare un array e inizializzarlo con valori predefiniti.");
            Console.WriteLine("Già fatto in precedenza");


            Console.WriteLine("Creare una lista che accetta solo valori univoci.");
            List<int> ints = new List<int>();
            AggiungiUnici(ints, 12);
            Console.WriteLine("Fatto\n");


            Console.WriteLine("Utilizzare un array per rappresentare una matrice di 3x3.");
            int[,] matrice = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Fatto\n");


            Console.WriteLine("Dichiarare una lista e cercare un elemento al suo interno");
            if (personaggi.Contains("Mel")) 
            { 
                Console.WriteLine("L'elemento Mel è presente nella lista.\n"); 
            } 
            else 
            { 
                Console.WriteLine("L'elemento Mel non è presente nella lista.\n"); 
            } 

            Console.WriteLine("Creare un array di oggetti e iterare sui valori.");
            Custom[] custom1 = { new Custom(), new Custom() };
            foreach (Custom elemento in custom1)
            {
                Console.Write(elemento.ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Utilizzare una lista per memorizzare i punteggi di un gioco.");
            List<float> punteggi = new List<float>();
            punteggi.Add(1.0f);
            punteggi.Add(2.0f);
            punteggi.Add(3.0f);
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare un array di char per rappresentare una parola.");
            char[] char1 = { 'E', 'P', 'I', 'C' };
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una lista che accetta solo valori di tipo float.");
            Console.WriteLine("Fatto per i punteggi\n");

            Console.WriteLine("Utilizzare un array per memorizzare i giorni della settimana.");
            string[] string1 = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una lista e modificarne gli elementi in base alla loro posizione.");
            punteggi[2] = 2.1f;
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare un array di stringhe e concatenare tutti i valori in un'unica stringa.");
            foreach(string elemento in string1)
            { 
                Console.WriteLine(elemento+ " "); 
            }
            Console.WriteLine();

            Console.WriteLine("Utilizzare una lista per memorizzare dati inseriti dall'utente.");
            try
            {
                string leggi = Console.ReadLine();
                punteggi.Add(float.Parse(leggi));
            }
            catch (Exception)
            {
                Console.WriteLine("Non è un float");
            }
            Console.WriteLine();

            Console.WriteLine("Dichiarare un array di numeri casuali.");
            int[] numeriCasuali = new int[5]; 
            Random random = new Random(); 
            for (int i1 = 0; i1 < 5; i1++) 
            { 
                numeriCasuali[i1] = random.Next(1, 100);
            }
            Console.WriteLine("Fatto");

            Console.WriteLine("Creare una lista che accetta solo valori superiori a 10.");
            List<int> list = new List<int>();
            Aggiungi(list, 12);
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Utilizzare un array per rappresentare una tabella di moltiplicazione.");
            int[,] tabellaMoltiplicazione = new int[4,4]; 
            for (int i1 = 1; i1 <= 4; i1++) 
            { 
                for (int j1 = 1; j1 <= 4; j1++) 
                { 
                    tabellaMoltiplicazione[i1 - 1, j1 - 1] = i1 * j1; 
                } 
            } 
            for (int i1 = 0; i1 < 4; i1++) 
            { 
                for (int j1 = 0; j1 < 4; j1++) 
                { 
                    Console.Write(tabellaMoltiplicazione[i1, j1] + " "); 
                } 
                Console.WriteLine(); 
            }


            Console.WriteLine("Dichiarare una lista e convertirla in array.");
            string[] personaggi2 = new string[personaggi.Count];
            for (int i1 = 0;i1 < personaggi2.Length; i1++)
            {
                personaggi2[i1] = personaggi[i1];
            }
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Premere invio per compilare la prossima parte");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            Console.WriteLine("CLASSI");
            Console.WriteLine("Creare una classe Persona con proprietà per nome e età e una classe Lavoro con parametri il nome e la descrizione.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dichiarare una classe con un costruttore parametrizzato.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una classe che implementa un metodo per calcolare un valore.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una classe che eredita da un'altra.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Aggiungere diversi metodi public all 'interno della classe 'Persona'");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una classe che contiene una lista come proprietà.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Creare una classe con proprietà indicizzate.");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Dentro a persona dichiarare un parametro di tipo Lavoro");
            Console.WriteLine("Fatto\n");

            Console.WriteLine("Fare un programma che data una lista di Persone e una lista di Lavori venga assegnato a ogni persona un Lavoro casuale");
            List<Persona> persone = new List<Persona> { new Persona("Atena", 30), new Persona("Penelope", 25), new Persona("Circe", 40) };
            List<Lavoro> lavori = new List<Lavoro> { new Lavoro("Cantante", "Canta", 10000), new Lavoro("Disegnatore", "Disegna", 20000), new Lavoro("Pilota", "Pilota", 30000) }; 
            Random rand = new Random(); 
            foreach (var elemento in persone) 
            { 
                int indiceCasuale = rand.Next(lavori.Count-1); 
                elemento.AssegnaLavoro(lavori[indiceCasuale]); 
            }

        }
        static int A(int a, int b)
        {
            GiorniDellaSettimana giorno=new GiorniDellaSettimana();
            giorno = GiorniDellaSettimana.Giovedi;
            return a + b;
        }

        static void B()
        { Console.WriteLine("Atena\n"); }

        static int C(string a)
        {
            return a.Length;
        }

        static void D(string a = "Penelope")
        { Console.WriteLine(a + "\n"); }

        static void E(int[] a)
        {
            Console.WriteLine(a[0] + " " + a[1] + "\n");
        }

        static void F()
        {
            int a = 5;
            for (int i = 4; i >= 1; i--)
            { a = a * i; }
            Console.WriteLine(a + "\n");
        }


        static bool G(int a)
        {
            if (a % 2 == 0)
                return true;
            else return false;
        }

        static void H()
        {
            try
            {
                Console.WriteLine("Entra un numero intero");
                string leggi = Console.ReadLine();
                int a = Convert.ToInt32(leggi);
                Console.WriteLine(a + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Non è un numero intero\n");
            }
        }

        static List<int> I()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            return list;
        }

        static Custom J(Custom a)
        { return a; }

        static void K(List<int> a)
        {
            a.Add(1);
        }

        static string M(int numero)
        {
            if (numero > 0) return "positivo"; else if (numero < 0) return "negativo"; else return "zero";

        }

        static bool IsPrime(int numero) 
        { 
            if (numero <= 1) 
                return false;
            int i = 2;
            while ( i <= Math.Sqrt(numero)) 
            { 
                if (numero % i == 0) 
                    return false;
                i++;
            } 
            return true; 
        }

        static bool IsPalindrome(string parola) 
        { 
            string inversa = new string(parola.ToCharArray().Reverse().ToArray()); 
            return parola == inversa; 
        }

        static void AggiungiUnici(List<int> list, int valore)
        {
            int a = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]==valore)
                    a++;
            }
            if (a == 0)
                list.Add(valore);
        }

        static void Aggiungi(List<int> lista, int valore) 
        { 
            if (valore > 10) 
            { 
                lista.Add(valore); 
                Console.WriteLine("Valore " +valore+" aggiunto alla lista."); 
            } 
            else 
            { 
                Console.WriteLine("Valore " +valore+ " non aggiunto alla lista perché non è superiore a 10."); 
            } 
        }

        class Custom
        {
            public int a;

            public Custom()
            {
                Random random = new Random();
                a= random.Next(0,10);
            }
        }

        class Lavoro 
        { 
            public string Nome { get; set; } 
            public string Descrizione { get; set; } 

            public double StipendioAnnuale { get; set; }
            public Lavoro(string nome, string descrizione, double stipendio) 
            { 
                Nome = nome; 
                Descrizione = descrizione; 
                StipendioAnnuale = stipendio;
            }    
            public string Stampa()
            {  
                return Nome + ": " + Descrizione; 
            }

            public double Stipendio()
            {
                return StipendioAnnuale/12;
            }
        } 
        class Persona 
        { 
            public string Nome { get; set; } 
            public int Eta { get; set; } 
            public Lavoro ? LavoroAttuale { get; set; } 
            public Persona(string nome, int eta, Lavoro lavoro) 
            { 
                Nome = nome; 
                Eta = eta;
                LavoroAttuale = lavoro;
            } 
            public Persona(string nome, int eta)
            {
                Nome = nome;
                Eta = eta;
                LavoroAttuale = null;
            }
            public void AssegnaLavoro(Lavoro lavoro) 
            { 
                LavoroAttuale = lavoro; 
            } 
            public string Stampa() 
            { 
                return Nome + ", " + Eta + "\n" + LavoroAttuale.Stampa(); 
            } 
        }

        class Studente : Persona 
        { 
            public string Scuola { get; set; } 
            public Studente(string nome, int eta, string scuola) : base(nome, eta) 
            { 
                Scuola = scuola; 
            } 
        }


        class Azienda 
        { 
            public List<Persona> Lavoratori { get; set; } 
            public Azienda() 
            { 
                Lavoratori = new List<Persona>(); 
            } 
            public void AggiungiLavoratore(Persona persona) 
            { 
                Lavoratori.Add(persona); 
            }
            public void Stampa() 
            { 
                foreach (var lavoratore in Lavoratori) 
                { 
                    lavoratore.Stampa(); 
                } 
            } 
        }

        class Indicizzato
        { 
            private string[] a = new string[10]; 
            public string this[int index] 
            { 
                get { return a[index]; } 
                set { a[index] = value; } 
            } 
        }


    }
}

