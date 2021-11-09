using UnityEngine;

public class TableCollision : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    [SerializeField] private GameObject sound;
    private bool failed;
    

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity);
        Instantiate(sound, collision.contacts[0].point, Quaternion.identity);
    }
}