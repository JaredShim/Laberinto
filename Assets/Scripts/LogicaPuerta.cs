using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaPuerta : MonoBehaviour
{
    public LogicaCofre llave;
    public Image mensajeNecesitasLlave;
    public Image pantallaGanar;
    public GameObject btnMenu;
    // Start is called before the first frame update
    void Start()
    {
        mensajeNecesitasLlave.enabled = false;
        pantallaGanar.enabled = false;
        btnMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player") && !llave.tomarLlave){
            mensajeNecesitasLlave.enabled = true;
        }
        if(other.CompareTag("Player") && llave.tomarLlave==true){
            pantallaGanar.enabled = true;
            btnMenu.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player") && !llave.tomarLlave){
            mensajeNecesitasLlave.enabled = false;
        }
    }
}
