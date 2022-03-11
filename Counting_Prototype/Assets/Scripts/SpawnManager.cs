using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> coins;
    private Button moreCointsButton;

    private float coinXRange = 3;

    // Start is called before the first frame update
    void Start()
    {
        moreCointsButton = GameObject.Find("More_Coins_Button").GetComponent<Button>();

        moreCointsButton.onClick.AddListener(SpawnCoins);

        SpawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoins()
    {
        for (var x = 0; x < 10; x++)
        {
            var index = Random.Range(0, coins.Count);

            var coinX = Random.Range(-coinXRange, coinXRange);

            Instantiate(
                coins[index],
                new Vector3(
                    25 + coinX,
                    18 + coinX,
                    2 + coinX
                ),
                coins[0].transform.rotation
            );
        }
    }
}
