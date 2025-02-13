using UnityEngine;

public class testingScript : MonoBehaviour
{
    int score;

    // Awake fonksiyonu oyun başlamadan önce bir kez çağrılır
    void Awake() {
        score = 0;
        Debug.Log("Awake fonksiyonu çağrıldı");
    }

    // Start fonksiyonu oyun başladığında bir kez çağrılır
    void Start()
    {
        score = 0;
        Debug.Log("Start fonksiyonu çağrıldı"); 
    }

    // Update fonksiyonu her frame'de çağrılır
    void Update()
    {
        Debug.Log("Update fonksiyonu çağrıldı");
    }

    // "düzenlenmiş update" olarak düşünülebilir
    // fiziksel işlemler için kullanılır
    // mesela zıplama için, fps değerleri bilgisayardan bilgisayar değiştiği için
    // zıplama miktarı değişebilir
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate fonksiyonu çağrıldı");
    }

    // Oyun objesi başka bir objeye çarptığında çağrılır (ai yazdı bunu)
    // geriden gelir, mesela kamera takip ederken
    // yavaş yavaş ölmüş bir fonksiyon, artık kullanılmıyormuş o kadar
    void LateUpdate() {
        
    }
}
