using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnStart : MonoBehaviour
{
    public UnityEvent onStart;
    void Start() => onStart?.Invoke();
}