using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_MovRotCompuestoJugador2 : MonoBehaviour
{
    [SerializeField]float velocidad_rotacion = 10f;
    [SerializeField]float velocidad_movimiento = 10f;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        float angulo = 100f  * velocidad_rotacion * Time.deltaTime;
        //              X    Y    Z
        
        if(Input.GetKey(KeyCode.U)){ //giro a la izquierda
            transform.Rotate(0,angulo * -1,0);
        }else if (Input.GetKey(KeyCode.O)) //giro a la derecha
        {
            transform.Rotate(0,angulo,0);
        }

        //arriba - abajo
        if (Input.GetKey(KeyCode.I)){            
            transform.position += transform.forward * velocidad_movimiento * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.K)){            
            transform.position += transform.forward * -1 * velocidad_movimiento * Time.deltaTime;
        }

        //izquierda - derecha
        if (Input.GetKey(KeyCode.J)){            
            transform.position += transform.right  * -1 * velocidad_movimiento * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.L)){            
            transform.position += transform.right * velocidad_movimiento * Time.deltaTime;
        }

    }
}
