using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class upgrade : MonoBehaviour
{
    public string product;

    public Image[] emptyIcons;
    public Sprite fillIcons;
    public Sprite emptyIcon;
    public int limit;

    void Start()
    {
        iconUpd();
    }

    public void upgraid()
    {
        int count = PlayerPrefs.GetInt(product);
        if (count < limit)
        {
            count++;
            PlayerPrefs.SetInt(product, count);
            emptyIcons[count - 1].overrideSprite = fillIcons;
        }
    }

    void iconUpd()
    {
        int count = PlayerPrefs.GetInt(product);
        for(int i = 0; i < count; i++)
        {
            emptyIcons[i].overrideSprite = fillIcons;
        }
    }
}
