using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItem : MonoBehaviour
{
    [SerializeField] private string itemName;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        //Debug.Log("Item collected: " + itemName);
        Managers.Inventory.AddItem(itemName);
        Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
