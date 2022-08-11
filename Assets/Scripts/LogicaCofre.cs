using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaCofre : MonoBehaviour
{
    //bool llave = false;
    public bool tomarLlave = false;
    public Image mensajeCofre;
    // Start is called before the first frame update
    void Start()
    {
        mensajeCofre.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player") && !tomarLlave){
            //Debug.Log("Has llegado al cofre");
            mensajeCofre.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player") && !tomarLlave){
            //Debug.Log("Te has alejado del cofre");
            mensajeCofre.enabled = false;
            tomarLlave = true;
        }
    }
}
