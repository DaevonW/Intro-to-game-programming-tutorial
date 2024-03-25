using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    // Start is called before the first frame update
    //global variables
    public float speed = 5f;
    private Vector3 target;
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("click to move");
            target = Camera.man.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
          
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
