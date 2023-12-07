using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Worker : MonoBehaviour
{
    public int count;
    public int cost;
    public TMP_Text WorkersCount;

    public void Buy()
    {
        if(GameManager.clicks >= cost)
        {
            count++;
            WorkersCount.text = count.ToString();
            GameManager.clicks -= cost;
        }

    }
}
