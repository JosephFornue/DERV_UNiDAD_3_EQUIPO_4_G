using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_PosiscionEnemigos : MonoBehaviour
{
    [SerializeField] Transform ubi_spawn;
    GameObject perri;

    private void Awake() {
        perri = GameObject.Find("Perri");
    }
    
    private void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.CompareTag("Player")){
            perri.transform.position = ubi_spawn.position;
        }
    }
}
