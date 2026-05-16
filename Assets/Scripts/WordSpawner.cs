using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    [SerializeField] private GameObject wordPrefab;

    public WordDisplay SpawnWord()
    {
        WordDisplay wordInstance = Instantiate(wordPrefab, transform).GetComponent<WordDisplay>();
        return wordInstance;
    }
}
