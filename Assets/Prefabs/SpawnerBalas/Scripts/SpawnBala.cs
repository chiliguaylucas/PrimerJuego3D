using UnityEngine;

public class SpawnBala : MonoBehaviour
{
    [SerializeField]private GameObject bala;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("crearBala",2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void crearBala()
    {
        Instantiate(bala,transform.position,transform.rotation);
    }
}
