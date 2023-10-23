using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCars : MonoBehaviour
{
    public Animator liftAnim;
    public float forceApplied = 0;

    private void Start()
    {
        liftAnim.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            liftAnim.SetBool("isLifting", true);
        }
        else
        {
            liftAnim.SetBool("isLifting", false);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Car") && (Input.GetKey(KeyCode.Space)))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * Vector3.up, ForceMode.Impulse);
        }
    }
}
