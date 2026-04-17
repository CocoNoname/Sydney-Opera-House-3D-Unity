#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class AddColliders : MonoBehaviour
{
    [MenuItem("Tools/Add Mesh Colliders")]
    static void AddMeshColliders()
    {
        MeshFilter[] meshFilters = Object.FindObjectsByType<MeshFilter>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        int count = 0;
        foreach (MeshFilter mf in meshFilters)
        {
            if (mf.GetComponent<MeshCollider>() == null)
            {
                mf.gameObject.AddComponent<MeshCollider>();
                count++;
            }
        }
        Debug.Log("Added colliders to " + count + " objects!");
    }
}
#endif