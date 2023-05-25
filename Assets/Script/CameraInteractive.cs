using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteractive : MonoBehaviour
{
    // Start is called before the first frame update
   // 
   // [SerializeField]
    public Transform _object;
    public float rayDistance = 2.0f;
    string filtro = "Interactable";
    void Start()
    {
      //  camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(_object.position, _object.forward * rayDistance, Color.red);


        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if (Physics.Raycast(_object.position, _object.forward, out hit, rayDistance, LayerMask.GetMask(filtro)))
            {
                Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Interactable>().Interact();
            }
        }
    }
    

}
