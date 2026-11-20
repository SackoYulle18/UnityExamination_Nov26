using UnityEngine;
using UnityEngine.Events;

public class SpawnObjectOnEvent : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    public UnityEvent onSpawn;

    public void SpawnObject(Vector3 position, Quaternion rotation) 
    {
        Instantiate(objectToSpawn, position, rotation);
        onSpawn?.Invoke();
    }
}
