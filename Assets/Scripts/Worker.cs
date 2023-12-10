using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Worker : MonoBehaviour
{
    public string name;
    public int count;
    public int cost;
    public int cps = 1;

    public AudioSource buy;

    public TMP_Text countText;
    public TMP_Text priceText;
    public Button button;

    void Start()
    {
        InvokeRepeating("Work", 1f, 1f);
        Load();
    }


    void Update()
    {
        countText.text = count.ToString();
        priceText.text = "price:" + cost;

        var canBuy = GameManager.clicks >= cost;
        button.interactable = canBuy;
    }


    public void Buy()
    {
        if (GameManager.clicks < cost) return;

        count++;
        GameManager.clicks -= cost;
        cost = (int)(cost * 1.3f);

        buy.Play();

        Save();
    }

    void Work()
    {
        GameManager.clicks += count * cps;
    }


    void Save()
    {
        PlayerPrefs.SetInt(name + "count", count);
        PlayerPrefs.SetInt(name + "cost", cost);
    }

    void Load()
    {
        count = PlayerPrefs.GetInt(name + "count");
        cost = PlayerPrefs.GetInt(name + "cost", cost);
    }
}
