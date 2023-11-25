using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinsLogic : MonoBehaviour
{
   public TMP_Text Coins;
    int coins = 0;
     public int lastaddedcoin;
    // Start is called before the first frame update
    void Start()
    {
        Coins.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCoins(int Coinstoadd)
    {
        coins += Coinstoadd;
        Coins.text = coins.ToString();
        lastaddedcoin = Coinstoadd;
    }
    public void AddCoins()
    {
        coins += lastaddedcoin;
        Coins.text = coins.ToString();
       
    }
}
