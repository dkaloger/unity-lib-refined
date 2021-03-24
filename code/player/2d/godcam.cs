using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godcam : MonoBehaviour
{
    [Range(0, 30)] public float scrollSpeed = 5f;
    public bool canScroll = true;
    public float speed;
    public Vector2 leftsidelimits, rightsidelimits;
    public float lowest_size, highest_size;



    void FixedUpdate()
    {



        GetComponent<Camera>().orthographicSize -= Input.mouseScrollDelta.y * scrollSpeed;
        GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize, lowest_size, highest_size);

        Vector3 moveinput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveinput = moveinput * (speed * GetComponent<Camera>().orthographicSize);
        transform.position += moveinput;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftsidelimits.x, rightsidelimits.x), Mathf.Clamp(transform.position.y, leftsidelimits.y, rightsidelimits.y), transform.position.z);
    }
}