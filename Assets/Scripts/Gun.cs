using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Bryann Alfaro
 * Clase que controla la pistola
 * Referencia: Youtube Brackeys y clase en linea
 */
public class Gun : MonoBehaviour

{
    //Propiedades
    public float damage = 50;
    public float range = 100;
    public Camera camara;
    public AudioClip gun_sound;

    private GameObject scoreObject;
    private Text score;

    private int scoreCantidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreObject = GameObject.FindGameObjectWithTag("Score");
        score = scoreObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){

            Shoot();
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(gun_sound);
        }

        if (score) {
            score.text = "Score: " + scoreCantidad.ToString();
        }
    }

    //Disparo
   void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(camara.transform.position, camara.transform.forward, out hit, range)) {

            Target target = hit.transform.GetComponent<Target>();
            if (target)
            {
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
                if (target.CompareTag("Player"))
                {
                    scoreCantidad = scoreCantidad + 1;
                }
            }
            
        
        };
    }
}
