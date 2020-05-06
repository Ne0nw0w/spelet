using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SawBlade : MonoBehaviour

{
    public Animator anim;
    private Vector3 pos;
    public float speed;
    public float minY;
    public float maxY;
    public float minX;
    public float maxX;
    public float direction;
    public bool forward = true;
    public bool horizontal = true;
    


    

    void Start()
    {
        direction = speed * 0.005f;
        pos.x = direction;
        pos.x = 0f;
        pos.y = 0f;

    }


    void Update()

    {
        if (horizontal)
        {
            if (forward && pos.x < maxX)
            {
                right();
            }
            else if (pos.x >= maxX)
            {
                forward = false;
            }
            if (!forward && pos.x > minX)
            {
                left();
            }
            else if (pos.x <= minX)
            {
                forward = true;
            }
        }


        if (!horizontal)
        {
            if (forward && pos.y < maxY)
            {
                up();
            }
            else if (pos.y >= maxY)
            {
                forward = false;
            }
            if (!forward && pos.y > minY)
            {
                down();
            }
            else if (pos.y <= minY)
            {
               forward = true;
            }
        }


            void up()
            {
                pos = transform.position;
                pos.y += direction;
                transform.position = pos;
                anim.SetBool("Vertical", true);
            }

            void down()
            {
                pos = transform.position;
                pos.y -= direction;
                transform.position = pos;
                anim.SetBool("Vertical", true);
            }

            void left()
            {
                pos = transform.position;
                pos.x -= direction;
                transform.position = pos;
                anim.SetBool("Vertical", false);
            }
            void right()
            {
                pos = transform.position;
                pos.x += direction;
                transform.position = pos;
                anim.SetBool("Vertical", false);
            }


    }
    

}
