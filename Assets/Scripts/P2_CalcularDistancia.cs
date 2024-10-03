using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class P2_CalcularDistancia : MonoBehaviour
{
    Transform ubi_obj_calc_dist;
    float distance;

    public float getDistance(){
        return distance;
    }

    private void Awake() {
        ubi_obj_calc_dist = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(
            transform.position,
            ubi_obj_calc_dist.position
        );
    }
}
