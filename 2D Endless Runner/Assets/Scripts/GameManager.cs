using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Menambah jumlah diamond yang dimiliki
    public int point;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreasePoint()
    {
        point++;
        pointText.text = point.ToString();
    }
}
