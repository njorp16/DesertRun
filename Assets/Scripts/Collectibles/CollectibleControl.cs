using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = coinCount.ToString();
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = coinCount.ToString();
    }
}
