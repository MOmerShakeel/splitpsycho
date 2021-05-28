using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinpicker : MonoBehaviour
{
    private float coin = 0;
    public TextMeshProUGUI textcoins;
    public GameObject GameWonPanel;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "coin")
        {   
            coin++;
            textcoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
        if (coin == 21){
            GameWonPanel.SetActive(true);
        }
    }
}
