using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{
    Transform cam;

    public Joystick joystickMove;
    public Joystick joystickGiro;
    public float speed = 9;

    public Transform player;
    public CharacterController controller;

    float x;
    float z;
    Vector3 move;

    //Rotacion
    float rotateV;
    float rotateH;
    public float speedGiro = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    void Move(){
          x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
          z = joystickMove.Vertical + Input.GetAxis("Vertical");

          move = player.right * x + player.forward * z;
          controller.Move(move * speed * Time.deltaTime);
    }

    void Rotate(){
        rotateH = joystickGiro.Horizontal * speedGiro;
        rotateV = -(joystickGiro.Vertical * speedGiro);
        cam.Rotate(rotateV,0,0);
        player.Rotate(0,rotateH,0);
    }
}
