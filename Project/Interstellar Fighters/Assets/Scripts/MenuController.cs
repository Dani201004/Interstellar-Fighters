using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance;

    public void Jugador1()
    {
        SceneManager.LoadScene(1);
    }

    public void Jugador2()
    {
        SceneManager.LoadScene(2);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Salirmenuprincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void Volverajugar1()
    {
        SceneManager.LoadScene(4);
    }
}