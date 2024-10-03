using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_collider : MonoBehaviour
{
     GameObject jugador;
    private void Awake() {
        jugador = GameObject.Find("Jugador");
    }
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Player2")){
            GameObject obj = other.gameObject;
            Destroy(obj);
        }
    }
}

