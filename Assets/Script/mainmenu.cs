using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Nivel1()
    {
        SceneManager.LoadScene("destroyed_cityn1");
    }

    public void Nivel2()
    {
        SceneManager.LoadScene("destroyed_cityn2");
    }

    public void EscenaDos(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
    }

    public void salir()
    {
        Application.Quit();
    }
}
