using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statics : MonoBehaviour
{

  public   static GameObject buildings_gameobject;


    [SerializeField]
    private GameObject buildings_gameobject_helper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buildings_gameobject = buildings_gameobject_helper;
    }
}
