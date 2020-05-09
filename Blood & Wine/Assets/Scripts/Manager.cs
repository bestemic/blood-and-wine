using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private DisplayMoney displayMoney;
    private DisplayDate displayDate;
    private int money = 1000;
    private int week = 1;
    private int month = 6;
    private int year = 1401;
    void Awake()
    {
        displayMoney = FindObjectOfType<DisplayMoney>();
        displayDate = FindObjectOfType<DisplayDate>();
        UpdateMoney();
        UpdateDate();
    }
    public void EndOfTurn()
    {
        money -= 20;
        money -= (int)(Random.value*5);
        UpdateMoney();
        NextDate();
        UpdateDate();
    }

    public void UpdateMoney()
    {
        displayMoney.UpdateMoney(money);
    }

    public void UpdateDate()
    {
        displayDate.UpdateDate(week, month, year);
    }
    private void NextDate()
    {
        week += 2;
        if(week > 3)
        {
            week = 1;
            month++;
        }
        if(month > 12)
        {
            month = 1;
            year++;
        }
    }


}
