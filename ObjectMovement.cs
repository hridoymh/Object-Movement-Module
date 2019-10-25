using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Transform pos1,pos2;
    Vector3 nextpos;
    
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {

        nextpos = pos1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position) nextpos = pos2.position;
        if (transform.position == pos2.position) nextpos = pos1.position;

        transform.position =  Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        col.gameObject.transform.parent = this.transform;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        col.gameObject.transform.parent = null;
    }

}
