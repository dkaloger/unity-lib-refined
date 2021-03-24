using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class constructionWheel : MonoBehaviour
{
  //  public float z;
    public Color default_color; 
 [System.NonSerialized]
    public int selected_segment = 0 ;
 [System.NonSerialized]
    public int segments = 4;

    public Tilemap buildings_Tilemap;


    public GameObject[] segments_gameobject;
    // Start is called before the first frame update
    void Start()
    {
        segments = segments_gameobject.Length-1 ;
}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            selected_segment--;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            selected_segment ++;
        }

        if (selected_segment < 0)
        {
            selected_segment = segments;
        }
        if (selected_segment > segments)
        {
            selected_segment = 0;
        }

        segments_gameobject[selected_segment].GetComponent<SpriteRenderer>().color = default_color;
        segments_gameobject[selected_segment].GetComponent<Animation>().Play();

        transform.position = new Vector3( Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
     
    }
}
