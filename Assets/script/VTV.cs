using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    // Start is called before the first frame update
    public string patente;
    public int modelo;
    public int kilometros;
    public int VencimientoVTV;
    public int HCppm;

    void Start()
    {

        if (patente == "")
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (HCppm < 100)
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (kilometros < 0)
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (VencimientoVTV < modelo || VencimientoVTV > 2025)
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (HCppm < 5)
        {
            Debug.Log("VTV no aprobada");

            return;
        }
        if (kilometros / (2025 - modelo) < 10000)
        {
            Debug.Log("VTV otorgada por 2 años");
        }
        if (kilometros / (2025 - modelo) > 10000)
        {
            Debug.Log("VTV otorgada por 1 año");
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
        

       



