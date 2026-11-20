using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello, World!");

        // Wo?
        string[] locations =
        {
            "Serverstadt",
            "digitales Archiv",
            "Pixelwald",
            "Computersystem eines Raumschiffs",
            "verlassenes Spiel",
            "unterirdisches Datennetz"
        };

        int randomLocation = Random.Range(0, locations.Length);

        // Warum ist das System beschädigt?
        string[] causes =
        {
            "ein fehlerhaftes Update",
            "ein Computervirus",
            "ein abgestürztes Programm",
            "gestohlene Bytes",
            "eine beschädigte Datei",
            "eine unterbrochene Verbindung"
        };

        int randomCause = Random.Range(0, causes.Length);

        // Was wird wiederhergestellt?
        string[] restores =
        {
            "Farben",
            "Erinnerungen",
            "Daten",
            "Energie",
            "Verbindungen",
            "Spielfelder"
        };

        int randomRestore = Random.Range(0, restores.Length);

        Debug.Log("Wo: " + locations[randomLocation]);
        Debug.Log("Ursache: " + causes[randomCause]);
        Debug.Log("Wiederherstellung: " + restores[randomRestore]);
    }

    void Update()
    {
        
    }
}