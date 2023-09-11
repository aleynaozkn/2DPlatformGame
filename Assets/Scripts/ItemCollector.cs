using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int carrots = 0;
    [SerializeField] private TextMeshProUGUI carrotsText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("carrot"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            carrots++;
            carrotsText.text = "Carrots: " + carrots;
        }
    }

}
