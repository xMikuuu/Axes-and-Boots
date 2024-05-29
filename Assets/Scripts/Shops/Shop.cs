using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // protected: public for child classes
    [SerializeField] protected string shopName;
    public string ShopName {  get { return shopName; }}

    [SerializeField] protected string shopID;
    public string ShopID { get {  return shopID; }}

    [SerializeField] protected Image shopCanvas;


    virtual public void EnterShop()
    {
        shopCanvas.gameObject.SetActive(true);
    }

    virtual public void ExitShop()
    {
        shopCanvas.gameObject.SetActive(false);
    }
}
