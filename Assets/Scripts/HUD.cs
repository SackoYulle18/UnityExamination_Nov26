using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class HUD : MonoBehaviour
{
    public GameObject HealthGUI,RedKeyGUI,GoldenKeyGUI, CoinsGUI;
    public List<GameObject> Hearts;
    public TextMeshProUGUI nrOfCoinsTxt;
    public int hp, nrOfCoins;
    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < hp; i++)
        {
            Hearts[i].SetActive(true);
        }

        nrOfCoinsTxt.text = nrOfCoins.ToString();
        
    }

    public void LoseHealth()
    {
        hp--;
        Hearts[hp].SetActive(false);
    }
    public void GainCoin() => nrOfCoins++;
}
