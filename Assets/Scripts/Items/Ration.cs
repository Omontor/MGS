using UnityEngine;

public class Ration : MonoBehaviour
{
    //aqui van las variables para el item de racion, como el sprite, el sonido al recogerlo, etc.
   // int = numeros enteros, float = numeros con decimales, string = texto, bool = verdadero o falso

    [SerializeField] private bool isSpining;
    [SerializeField] private float spinSpeed;
    [SerializeField] private AudioClip pickUpSound;
    [SerializeField] private AudioSource audioSource;


    void Init()
    {
       isSpining = true;
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
