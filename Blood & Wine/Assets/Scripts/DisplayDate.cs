using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDate : MonoBehaviour
{
    private TextMeshProUGUI textmeshpro;
    private string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
    void Awake()
    {
        textmeshpro = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDate(int week, int month, int year)
    {
        textmeshpro.SetText("Week " + week + " | " + months[month - 1] + " " + year + " AD");
    }
}
