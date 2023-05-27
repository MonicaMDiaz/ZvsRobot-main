using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatosRobot : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void EscenaUno()
    {
        SceneManager.LoadScene("destroyed_cityn1");
    }

    public void EscenaDos()
    {
        SceneManager.LoadScene("destroyed_cityn2");
    }

    public void EscenaTres()
    {
        SceneManager.LoadScene("destroyed_cityn3");
    }

    public void Menu1()
    {
        SceneManager.LoadScene("menu_1");
    }

    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer <= 0)
        {
            Debug.Log("Game over");
            Menu();
        }
        else if (SceneManager.GetActiveScene().name == "destroyed_cityn1")
        {
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("zombie");

            if (enemigos.Length == 0)
            {
                EscenaDos();
            }
        }
        else if (SceneManager.GetActiveScene().name == "destroyed_cityn2")
        {
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("zombie");

            if (enemigos.Length == 0)
            {
                EscenaTres();
            }
        }
        else if (SceneManager.GetActiveScene().name == "destroyed_cityn3")
        {
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("zombie");

            if (enemigos.Length == 0)
            {
                Menu1();
            }
        }
    }
}