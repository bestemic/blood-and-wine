using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayMoney : MonoBehaviour
{
    private TextMeshProUGUI textmeshpro;
    void Awake()
    {
       textmeshpro = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMoney(int money)
    {
        textmeshpro.SetText("Money: {0}", money);
    }
}
