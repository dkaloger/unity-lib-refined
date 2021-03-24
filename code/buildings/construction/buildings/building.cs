using UnityEngine;
using UnityEngine.Tilemaps;
[CreateAssetMenu (fileName ="new building" ,menuName ="building")]
public class building : ScriptableObject
{
    public int id;
    public Tile tile;

    public Sprite sprite;
   // public GameObject logic;
    public int cost;

}

 
