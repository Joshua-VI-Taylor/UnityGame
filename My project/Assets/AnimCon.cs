using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCon : MonoBehaviour
{
    public Animator Anim;
    public GameObject Cam;
    public CharacterController controllor;
    public Collider col;
    public Transform desk;
    private void Start()
    {
         Cam.transform.position.Set(1, 1, 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Anim.SetBool("Walk", true);
           
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Anim.SetBool("Walk", false);
            
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
          
                Anim.SetBool("Run", true);
           
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Anim.SetBool("Run", false);
        }
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("Eat", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Anim.SetBool("Eat", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.SetBool("Turn Head", true);
            Cam.transform.parent = null;
            Cam.transform.parent = GameObject.Find("RigNeck").transform;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            Anim.SetBool("Turn Head", false);
            
            
            
        }
    }
}
 