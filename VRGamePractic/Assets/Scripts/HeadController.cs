using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _forcepower;
    private const string WEAPON_TAG = "Weapon";

    private void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag(WEAPON_TAG))
        {
            return;
        }
        _rigidbody.isKinematic = false;
        _rigidbody.AddForce(Vector3.up * _forcepower);


    }





    /*[SerializeField] private Rigidbody _rigidbody;
    private float _forcepower = 50;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Weapon1"))
        {
            _forcepower = 25;
            Action(_forcepower);
        }
        else if (collider.CompareTag("Weapon2"))
        {
            _forcepower = 100;
            Action(_forcepower);
        }
        else if (collider.CompareTag("Weapon3"))
        {
            Action(_forcepower);
        }
        else
        {
            return;
        }

    }
    private void Action(float _forcepower)
    {
        _rigidbody.isKinematic = false;
        _rigidbody.AddForce(Vector3.up * _forcepower);
    }*/




}



