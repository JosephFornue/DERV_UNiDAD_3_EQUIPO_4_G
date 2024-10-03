using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_MovimientoEnemigo : MonoBehaviour
{

    Transform ubi_personaje;
    P2_CalcularDistancia auxComponenteDistance;
    private void Awake() {
        ubi_personaje = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        auxComponenteDistance = GetComponent<P2_CalcularDistancia>();//obteniendo los componentes del propio scrips
    }

    // Update is called once per frame
    void Update()
    {
        float distanceAlEnemigo = auxComponenteDistance.getDistance();
        if (distanceAlEnemigo < 6.5f && distanceAlEnemigo > 1.7f){//umbral de distancia con el personaje
        float velocidad = 4.0f * Time.deltaTime;
        transform.position =  Vector3.MoveTowards(transform.position, ubi_personaje.position, velocidad);
    }                       //Vector3 
}
}