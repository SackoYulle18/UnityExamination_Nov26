using UnityEngine;
using System.Collections.Generic;

public class SetSpriteBasedOnColor : MonoBehaviour
{
    public enum SpriteColor
    {
        Blue, Green, Red, Yellow
    }

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] switchableSprites = new Sprite[4];

    public SpriteColor SelectedSpriteColor => spriteColor;

    [SerializeField] private SpriteColor spriteColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        switch(spriteColor)
        {
            case SpriteColor.Blue:
                spriteRenderer.sprite = switchableSprites[0];
                break;
            case SpriteColor.Green:
                spriteRenderer.sprite = switchableSprites[1];
                break;
            case SpriteColor.Red:
                spriteRenderer.sprite = switchableSprites[2];
                break;
            case SpriteColor.Yellow:
                spriteRenderer.sprite = switchableSprites[3];
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
