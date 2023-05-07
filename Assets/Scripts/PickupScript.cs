using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupScript : MonoBehaviour
{
    
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        SetCountText();
        winTextObject.SetActive(false); 
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("PickUp")){
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }

    void SetCountText(){
        countText.text = "Score: " + count.ToString();
        if(count >= 22){
            winTextObject.SetActive(true);
        }
    }
}
