using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class P4_cambioColor : MonoBehaviour
{
     [SerializeField] Material color1;
     [SerializeField] Material color2;
     int estado;
     
    // Start is called before the first frame update
    void Start()
    {
        estado = 0;
    }
    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision other) {
        GameObject obj = other.gameObject;
        if(other.gameObject.CompareTag("Pobre"))
        {
            if(estado==0){
            GetComponent<Renderer>().material = color2;
            estado=1;
            }
            else if(estado ==1){
                GetComponent<Renderer>().material = color1;
                estado =0;
            }
        }

    }
}
