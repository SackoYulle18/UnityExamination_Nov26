using System;
using UnityEngine;
using UnityEngine.Events;

public class KeyLock : MonoBehaviour
{
    private SetSpriteBasedOnColor ssboc;
    private bool unlockable;

    public UnityEvent onUnlock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ssboc = GetComponent<SetSpriteBasedOnColor>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (MathF.Abs(transform.position.y - 
                          other.gameObject.transform.position.y) > 0.5f) 
                return;
            
            if(unlockable)
            {
                UnLock();
            }
        }
    }

    private void UnLock()
    {
        Debug.Log($"The {gameObject.name} has been unlocked");
        onUnlock?.Invoke();
    }

    public void CollectKeyByColor(SetSpriteBasedOnColor.SpriteColor color)
    {
        unlockable = true;
    }
}
