using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class combat : MonoBehaviour
{
  public GameObject projectile;
    GameObject latest_projectile;
    public float projectile_speed;
    public GameObject projectiles;
    public Vector3 shootDirection;
    public float cooldown;
    public float t;
    public float charge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        shootDirection = Input.mousePosition;
        shootDirection.z = -0.03f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection.z = -0.03f;
        GameObject.FindGameObjectWithTag("mouse").transform.position = shootDirection;

        if (t < cooldown + 1)
        {
            t++;
        }

        statics.rechargeui.GetComponent<Image>().fillAmount = t / cooldown;
        if (Input.GetMouseButton(1) && t > cooldown)
        {
            charge++;
         

        }
        if (Input.GetKeyUp(KeyCode.Mouse1) && charge > cooldown)
        {
            latest_projectile = Instantiate(projectile, transform.position, Quaternion.Euler(Vector3.zero));
            latest_projectile.transform.up = GameObject.FindGameObjectWithTag("mouse").transform.position - latest_projectile.transform.position;
            latest_projectile.GetComponent<projectile>().damage = charge;
            charge = 0;
            t = 0;
        }
        if (Input.GetMouseButtonDown(0) && t > cooldown)
        {

            t = 0;


            latest_projectile = Instantiate(projectile, transform.position, Quaternion.Euler(Vector3.zero));
            latest_projectile.transform.up = GameObject.FindGameObjectWithTag("mouse").transform.position - latest_projectile.transform.position;
            latest_projectile.GetComponent<projectile>().damage = 60;
            //       latest_projectile.transform.position += ((latest_projectile.transform.forward / 100) * projectile_speed) / 60 ;

        }

     
    }
}
