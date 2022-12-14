using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieW : MonoBehaviour
{
    public float velMov, velRot;

    public float tiempoReac;
    int movimiento;

    bool espera, camina, gira;

    private void Start(){
        accion();
    }

    private void Update(){

        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.forward, out hit, 10)){
            if(hit.collider){
                gira = true;
                StartCoroutine(tiempoGiro());
            }
        }

        if(camina){
            GetComponent<Animator>().SetBool("activo",true);
            transform.position += (transform.forward * velMov * Time.deltaTime);
        }
        if(gira){
            transform.Rotate(Vector3.up * velRot * Time.deltaTime);
        }
    
        if(espera){
            GetComponent<Animator>().SetBool("activo",false);
        }

    }

    void accion(){
        movimiento = Random.Range(1, 4);

        if(movimiento == 1){
            camina = true;
            espera = false;
        }

        if(movimiento == 2){
            espera = true;
            camina = false;
        }

        if(movimiento == 3){
            gira = true;
        StartCoroutine(tiempoGiro());
        }

        Invoke("accion", tiempoReac);
    }

    IEnumerator tiempoGiro(){
        yield return new WaitForSeconds(2);
        gira = false;
    }
}
