using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedWithAnim : MonoBehaviour
{
    private Animator animator;
    private int speed = 2;
    private float speedjump = 0.5f;
    public GameObject gameObject;

    [SerializeField] [Range(0, 1)] float d;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move(speed);
        if (animator != null && Input.GetKey(KeyCode.LeftShift))
        {
           if (d<1f)
           {
                speed = 5;
                d += 0.05f;
           }
            animator.SetFloat("AminFloat", d);
        }
        else
        {
            if (d >0.05f)
            {
                speed = 2;
                d -= 0.05f;
            }
            animator.SetFloat("AminFloat", d);    
        }
    }
    private void Move(int speed)
    {
        if (Input.GetKey(KeyCode.W))
        { 
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("AnimTrigger");
            gameObject.transform.Translate(Vector3.up*speedjump);
        }
    }
}


