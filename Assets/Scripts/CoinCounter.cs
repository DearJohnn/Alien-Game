using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coin;

    private void Update()
    {
        coin.text = GameManager.coin.ToString();
    }
}
