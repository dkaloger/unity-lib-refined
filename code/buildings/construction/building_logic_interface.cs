using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building_logic_interface : MonoBehaviour
{
   public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        statics.buildings_gameobject.SendMessage("function" + id);
    }
}
