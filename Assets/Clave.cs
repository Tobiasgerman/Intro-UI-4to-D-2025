using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clave : MonoBehaviour
{
    public  TMP_InputField InputClave;
    public TextMeshProUGUI Txtresultado;
    string clave ="tobi1";
    string claveIngresada;
    string mensaje;
   
    // Start is called before the first frame update
    void Start()
    {
        Txtresultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void msj()
    {
        claveIngresada = InputClave.text;
        if (claveIngresada == clave)
        {
            mensaje = "Clave Correcta";
        } else if  (claveIngresada != clave)
        {
            mensaje = "Clave incorrecta";
            
        }
        Txtresultado.text = mensaje;
    }
}
