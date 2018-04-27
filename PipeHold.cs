using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHold : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (BirdController.instance != null)
        {
            if (BirdController.instance.flag == 1)
            {
                Destroy(GetComponent<PipeHold>());
            }
        }
        _PipeMovement2();
    }

    void _PipeMovement2()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }
}