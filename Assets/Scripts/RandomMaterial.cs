using UnityEngine;

public class RandomMaterial : MonoBehaviour
{
    [SerializeField] private Material[] materials;
    [SerializeField] private MeshRenderer mesh;

    private void Awake()
    {
        mesh.material = materials[Random.Range(0, materials.Length)];
    }
}