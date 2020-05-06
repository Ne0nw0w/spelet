using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject key;
    public GameObject box;


    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag  == "Sawblade")
        {
            key.SetActive(true);
            box.SetActive(false);
        }
    }
}
