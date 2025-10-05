using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    #region Atributos
    private Vector3 offset;
    private PlayerMovement playerMovement;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = new Vector3(0, 1, -5);
        playerMovement = FindFirstObjectByType<PlayerMovement>();
    }
    private void LateUpdate()
    {
       gameObject.transform.position = playerMovement.transform.position + offset;
    }

}
