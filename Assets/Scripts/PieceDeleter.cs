using UnityEngine;

public class PieceDeleter : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}