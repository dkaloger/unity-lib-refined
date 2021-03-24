using System.Collections.Generic;
using UnityEngine;

public class playercontrollertopdown : MonoBehaviour
{
    Animator m_Animator;
    public int Hpnow;
    public int HpMax;
    public float speed = 100;
    public int BaseAttack = 10;
    public int ActualAttack = 10;
    void Start()
    {
        //Get the animator, which you attach to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Vector3 change;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        
        change.z = 0;
        transform.position += ((change / 100)* speed) /60;
        //Vector3.MoveTowards(transform.position, transform.position + change, speed);
        m_Animator.SetFloat("speed",Mathf.Abs( Input.GetAxisRaw("Horizontal")) +Mathf.Abs( Input.GetAxisRaw("Vertical")));
        if(Input.GetAxisRaw("Horizontal") > 0.1)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 180, transform.rotation.eulerAngles.z);
        }
        if (Input.GetAxisRaw("Horizontal") < -0.1)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
        }
    }
}
