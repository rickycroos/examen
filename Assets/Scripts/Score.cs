using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
   private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }
    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
