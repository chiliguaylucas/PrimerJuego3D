using UnityEngine;
/// <summary>
/// Permite el comportamiento del movimiento del jugador
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// Fuerza utilizada para aplicar movimiento
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Representa el tiempo que ha transcurrido desde la ultima
    /// aplicacion de fuerzas
    /// </summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo debe aplicarse 
    /// la fuerza
    /// </summary>
    private float intervaloTiempo;
    #endregion
    /// <summary>
    /// indica la velocidad aplicada en el movimiento lateral
    /// </summary>
    private float velocidadLateral;
    /// <summary>
    /// Representa la strategia de movimiento
    /// </summary>
    private IMovementStrategy strategy;
    private Player player;

    #region Ciclo de vida del Script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 5f;
        player = new Player(5f,5f);
       // SetStrategy(new MovimientoLateral());
        //SetStrategy(new MovimientoAcelerado());
    }
  
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
         }

    }
    #endregion
    public void MovePlayer( float input)
    {
        strategy.Move(transform, player,input);
    }

    #region Logica del script
    public void SetStrategy(IMovementStrategy strategy)
     { 
        this.strategy = strategy;
     }
    #endregion
   
}
