using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verRA : MonoBehaviour
{
    public GameObject btnPPrincipal;
    public GameObject btnZPolicia;
    public GameObject btnZMutante;
    // Start is called before the first frame update
    void Start()
    {
        btnPPrincipal.SetActive(false);
        btnZPolicia.SetActive(false);
        btnZMutante.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
