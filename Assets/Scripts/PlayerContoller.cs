using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float velocidadInicial = 5f;
    

    void Start()
    {
       
    }

    void Update()
    {
        // Movimiento de izquierda a derecha
        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidadInicial * Time.deltaTime;
        transform.Translate(new Vector3(movimientoHorizontal, 0, 0));
    }

}
