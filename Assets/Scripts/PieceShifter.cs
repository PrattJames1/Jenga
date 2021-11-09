using UnityEngine;

public class PieceShifter : MonoBehaviour
{
    [SerializeField] private float scaleShift = 0.01f;
    [SerializeField] private float massShift = 0.01f;
    [SerializeField] private Vector2 positionShift;

    private void Awake()
    {
        // random mass
        var rb = GetComponent<Rigidbody>();
        rb.mass += Random.Range(-massShift, massShift);

        // random scale
        transform.localScale += Random.Range(-scaleShift, scaleShift) * Vector3.one;

        // random position
        var randomXPosition = Random.Range(-positionShift.x, positionShift.x);
        var randomZPosition = Random.Range(-positionShift.y, positionShift.y);
        transform.position += new Vector3(randomXPosition, 0, randomZPosition);
    }
}