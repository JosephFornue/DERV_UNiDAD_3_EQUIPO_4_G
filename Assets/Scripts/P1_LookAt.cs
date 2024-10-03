using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class P1_LookAt : MonoBehaviour
{
    Transform ubi_obj_mirar;
    P2_CalcularDistancia auxComponenteDistance;

    private void Awake() {
        ubi_obj_mirar = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    void Start()
    {
        auxComponenteDistance = GetComponent<P2_CalcularDistancia>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceAlEnemigo = auxComponenteDistance.getDistance();
        if (distanceAlEnemigo < 6.5f){

            float valY = ubi_obj_mirar.position.y;

        if (valY>3.0f){//si esta por esima del umbral (3.0f)
                    transform.LookAt(new Vector3(
                        ubi_obj_mirar.position.x,
                        3.0f,
                        ubi_obj_mirar.position.z
                    ));
                }       

        else{
        transform.LookAt(ubi_obj_mirar.position);
        }
    }
}
}