using UnityEngine;

public class PracticaE1 : MonoBehaviour
{
    public Mesh cubeMesh;
    public Material cubeMaterial;
    void Start()
    {
        GameObject empty = new GameObject();
        empty.name = "Empty";
        empty.transform.position = new Vector3(1, 2, 0);
        empty.transform.rotation = Quaternion.Euler(0, 45, 0);
        empty.transform.localScale = new Vector3(1, 2, 1);
        MeshFilter meshFilter = empty.AddComponent<MeshFilter>();
        MeshRenderer meshRenderer = empty.AddComponent<MeshRenderer>();
        empty.AddComponent<BoxCollider>();
        meshFilter.mesh = cubeMesh;
        meshRenderer.material = cubeMaterial;
    }
}
