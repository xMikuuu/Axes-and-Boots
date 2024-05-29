using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // protected: public for child classes
    [SerializeField] protected string shopName;
    public string ShopName {  get { return shopName; }}

    [SerializeField] protected string shopID;
    public string ShopID { get {  return shopID; }}


    virtual public void EnterShop(int id)
    {

    }
}
