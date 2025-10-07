using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    void Start()
    {
        ShowWelcomeMessage("Kim");
        ShowWelcomeMessage("Jelle");
        ShowWelcomeMessage("Tim"); // Roep onze functie aan
    }

    void ShowWelcomeMessage(string name)
    {
        Debug.Log("=================");
        Debug.Log("Hee! " + name + "!");
        Debug.Log("Welkom bij mijn game!");
        Debug.Log("Veel plezier!");
        Debug.Log("================="); 
    }
}