using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animais : MonoBehaviour
{
    public Transform destination;
    public float speed = 5f;
    private void Update()
    {
        if (destination != null)
        {
            Vector3 direction = (destination.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, destination.position) < 0.1f)
            {
                //Debug.Log("Caminhao chegou no destino");
             
            }
        }
    }


}
