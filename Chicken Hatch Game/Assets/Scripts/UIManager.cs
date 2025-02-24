using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI eggCountText, chickCountText, henCountText, roosterCountText;
    public int eggCount, chickCount, henCount, roosterCount;
    // Start is called before the first frame update
    void Start()
    {
        eggCount = 1;
        chickCount = 1;
        henCount = 1;
        roosterCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        eggCountText.text = eggCount.ToString();
        chickCountText.text = chickCount.ToString();
        henCountText.text = henCount.ToString();    
        roosterCountText.text = roosterCount.ToString();
    }
}
