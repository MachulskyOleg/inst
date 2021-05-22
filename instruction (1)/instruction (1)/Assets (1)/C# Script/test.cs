using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Type { PlusPosition, ForceRigidbody }
public class test : MonoBehaviour
{
    public Type TypeOf;
    public Transform player;
    [SerializeField]
    public int speed;
    [SerializeField]
    public int jumpImpulse;
    Rigidbody playMov;
    //public bool isJump;//чтобы не прыгал вечно

    void Start()
    {
        player = transform;
        playMov = GetComponent<Rigidbody>();
      
    }   

    void FixedUpdate()
    {
        //в зависимости от типа управления
        if (TypeOf == Type.PlusPosition)
        {
            if (Input.GetKey(KeyCode.W))
            {
                player.position += player.forward * speed * Time.fixedDeltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                player.position -= player.forward * speed * Time.fixedDeltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                player.position += player.right * speed * Time.fixedDeltaTime;
            }

            if (Input.GetKey(KeyCode.A))
            {
                player.position -= player.right * speed * Time.fixedDeltaTime;
            }
        }
        else
        {

            if (Input.GetKey(KeyCode.W))
            {
                playMov.AddForce(transform.forward * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }

            if (Input.GetKey(KeyCode.S))
            {
                playMov.AddForce(-transform.forward * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }

            if (Input.GetKey(KeyCode.D))
            {
                playMov.AddForce(transform.right * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            }

            if (Input.GetKey(KeyCode.A))
            {
                playMov.AddForce(transform.forward * speed * Time.fixedDeltaTime, ForceMode.Impulse);
                //player.gameObject.GetComponent<Rigidbody>().AddForce(-player.right * speed * Time.deltaTime, ForceMode.Impulse);
                //playMov.AddForce (-transform.right * speed * Time.deltaTime,ForceMode.Impulse);
            }
        }

        //if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        //{
          //  Jump();
       // }
    }
}

