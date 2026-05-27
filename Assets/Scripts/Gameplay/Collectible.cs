using UnityEngine;

public enum CollectibleType
{
    Ration,
    Cigarettes,
}


public class Collectible : MonoBehaviour
{
    // int = numeros enteros, float = numeros con decimales, string = texto, bool = verdadero o falso
    [SerializeField] public CollectibleType collectibleType;
    [SerializeField] protected bool isSpining;
    [SerializeField] protected float spinSpeed;
    [SerializeField] protected AudioClip pickUpSound;
    [SerializeField] protected AudioSource audioSource;
    public int maxHeld;
    
    private void Start()
    {
        Init();
       
    }

    void Init()
    {
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            if(InventoryManager.Instance.canTakeItem(this))
            {
                OnPlayerPickedUp();
            }
            else
            {
                Debug.Log("No puedes llevar más de este item");
            }
        }
        else
        {
            Debug.Log("Not Player");
        }
    }


    void OnPlayerPickedUp()
    {
        isSpining = false;
        //Agregar lógica de inventario aquí
        InventoryManager.Instance.AddItemToInventory(this);
        Debug.Log("Player ha recogido el item " + collectibleType);
        gameObject.SetActive(false);
        
    }
    
    
    void Update()
    {
        if (isSpining == true)
        {
            transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
    }
    void Cleanup()
    {
        isSpining = false;
    }
    
    

}
