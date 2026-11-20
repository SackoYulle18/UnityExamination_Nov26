using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.UI;
using UnityEngine.Events;

public class GetDialogue : MonoBehaviour
{
    public List<string> dialogues;
    public TextMeshProUGUI dialogue_txt;
    [SerializeField] private float printAwaitTime;

    public UnityEvent onAfterPrint, onAfterLastPrint, onNext, onLast;

    public int Current = 0;
    private int previous = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue_txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Current != previous && Current < dialogues.Count)
        {
            StartCoroutine(Print());
            previous = Current;
        }
    }

    public IEnumerator Print()
    {
        for (int i = 0; i < dialogues[Current].Length;)
        {
            yield return new WaitForSeconds(printAwaitTime);
            string currentDialogueText = dialogues[Current];
            dialogue_txt.text += currentDialogueText[i];
            i++;
        }

        yield return new WaitForSeconds(1f);
        
        if (Current < dialogues.Count - 1)
            onAfterPrint?.Invoke();
        else
            onAfterLastPrint?.Invoke();
    }

    public void Next()
    {
        onNext?.Invoke();
        Current++;
        dialogue_txt.text = "";
    }

    public void Last()
    {
        onLast?.Invoke();
    }
}
