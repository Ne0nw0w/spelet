using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMenu : MonoBehaviour
{
    public float delta;
    public float scaleX, scaleY;
    public Camera cam1;
    public float speed = 1.0f;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cam1.orthographicSize > 5)
        {
            delta = 8;
        }
        else if(cam1.orthographicSize <= 5)
        {
            delta = 11;
        }
        //delta = cam1.orthographicSize;
        //delta = cam1.GetComponent<CameraScript>().orthSize;
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
