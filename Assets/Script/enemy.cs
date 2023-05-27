using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int damage;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Player.GetComponent<DatosRobot>().vidaPlayer -= damage;
        }

        if(other.tag == "zombie")
        {
            Debug.Log("Esto es un enemigo");
        }
    }
}
