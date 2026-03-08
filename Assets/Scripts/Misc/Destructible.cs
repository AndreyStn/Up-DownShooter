using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Destructible : MonoBehaviour
{
    [SerializeField] private GameObject _destroyedVFX;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<DamageSource>())
        {
            Instantiate(_destroyedVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
