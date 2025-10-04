using UnityEngine;

public class EjemploInvokes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Invoke("MostrarMensajeUnico", 5f);

         InvokeRepeating("MostrarMensajeRepetido", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostrarMensajeUnico()
    {
        Debug.Log("Ejecutando luego de 5 segundos");
    }
    public void MostrarMensajeRepetido()
    {
        Debug.Log("Ejecutando cada 2 segundos");
    }
}
