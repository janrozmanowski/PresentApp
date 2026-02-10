using UnityEngine;
using TMPro; //behövs för text
using UnityEngine.UI;
using System; //behövs för button

public class mainscript : MonoBehaviour
{
    public Button onskelista;
   public Button spara;
    public Button tabort;
    public TMP_InputField bday;
   public TMP_InputField namn;
    public TMP_InputField wishlist;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onskelista.onClick.AddListener(NewWishlist);
        spara.onClick.AddListener(Savewishlist);
        tabort.onClick.AddListener(Savewishlist);
    }

    void NewWishlist()
    {
        Debug.Log("new wishlist created");
    }
    void Savewishlist()
    {
        Debug.Log("wishlist saved");
    }
    void deletewishlist()
    {
        Debug.Log("wishlist delted");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
