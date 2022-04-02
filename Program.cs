

// See https://aka.ms/new-console-template for more information
int counter = 0;
// Read the file and display it line by line.  
foreach (string line in File.ReadLines("./texto.txt"))
{
    counter++;
    string[] palavras = line.Split('|');
    if (palavras[0] == "GATO" && int.Parse(palavras[2]) < 5 && int.Parse(palavras[2]) > 0)
    {
        Dictionary<string, int> gatos = new Dictionary<string, int>();
        gatos.Add(palavras[0],  int.Parse(palavras[2]));
        foreach (KeyValuePair<string, int> gato in gatos)
        {
            Console.WriteLine("{" + "Animal: " + gato.Key + "," + " Idade: " + gato.Value + "}");
        }
    } else if (palavras[0] == "CACHORRO" && int.Parse(palavras[2]) < 100 && int.Parse(palavras[2]) > 0)
        {
            Dictionary<string, int> cachorros = new Dictionary<string, int>();
            cachorros.Add(palavras[0], int.Parse(palavras[2]));
            foreach (KeyValuePair<string, int> cachorro in cachorros)
            {
              Console.WriteLine("{" + "Animal: " + cachorro.Key + "," + " Idade: " + cachorro.Value + "}");
            }
        }
}

