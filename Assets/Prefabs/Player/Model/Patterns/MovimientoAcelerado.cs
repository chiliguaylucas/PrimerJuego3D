using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    
    public void Move(Transform transform, Player player, float direction)
    {
        float movement = direction * (player.Velocidad + player.Aceleracion)* Time.deltaTime;
        transform.Translate(movement*Time.deltaTime, 0, 0);
    }
}