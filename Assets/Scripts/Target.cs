using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    private Vector3 posicionInicial;
    private int velocidad_Programa = 2;
    public float health = 50;

   

    void Start()
    {
        posicionInicial = transform.localPosition;

    }

    void Update()
    {
        transform.localPosition = posicionInicial + new Vector3(0, Mathf.Sin(Time.time * velocidad_Programa), 0);

    }

    public void TakeDamage(float amount) {

        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    
    }

    void Die()
    {
         
        Destroy(gameObject);
       
    }

}
