using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [HideInInspector]
    public CoinsLogic Log;
    public int CoinValue;
    internal RandomColorObjectSpawner.ObjectColor color;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            if (color == RandomColorObjectSpawner.ObjectColor.Red)
            {
               
                Log.AddCoins(CoinValue);
                GetComponent<AudioSource>().Play();
                StartCoroutine(destroy());
            }
            else if (color == RandomColorObjectSpawner.ObjectColor.Blue)
            {
                Log.AddCoins(CoinValue);
                GetComponent<Animator>().SetBool("Dest",true);
                StartCoroutine(destroy());
                

            }
            else if (color == RandomColorObjectSpawner.ObjectColor.Yellow)
            {
                Log.AddCoins();
                Destroy(this.gameObject);
            }
                

            
        }
    }
}
