using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class place : MonoBehaviour
{
  //public GameObject building_parent;

   //public building [] buildings_array;
  //  public Tile[] q;
    public Tilemap buildings;
    public building[] buildings_array;
    public GameObject place_point;
    GameObject latest;
    public SpriteRenderer[] images;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = buildings_array[i].sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& buildings.GetTile(buildings.layoutGrid.WorldToCell(place_point.transform.position)) ==  null)
        {
            buildings.SetTile(buildings.layoutGrid.WorldToCell(place_point.transform.position), buildings_array[0].tile);

            latest = Instantiate(new GameObject(buildings_array[0].name + "_logic"), place_point.transform.position, new Quaternion(0, 0, 0, 0));
            latest.AddComponent<building_logic_interface>().id = buildings_array[0].id;

        }

    }
}
