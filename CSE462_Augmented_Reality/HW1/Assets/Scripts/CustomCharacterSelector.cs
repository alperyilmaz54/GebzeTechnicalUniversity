using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CustomCharacterSelector : MonoBehaviour
{
    public GameObject[] characters;
    private int currentIndex = 0;
    private GameObject currentCharacter;

    void Start()
    {
        if ( characters.Length > 0 )
        {
            ShowCharacter( 0 );
        }
    }

    public void NextCharacter()
    {
        ++currentIndex;
        if ( currentIndex >= characters.Length )
            currentIndex = 0;

        ShowCharacter( currentIndex );
    }

    public void PreviousCharacter()
    {
        --currentIndex;
        if (currentIndex < 0)
            currentIndex = characters.Length - 1;

        ShowCharacter(currentIndex);
    }

    void ShowCharacter(int index)
    {
        if (currentCharacter != null)
            Destroy(currentCharacter);

        currentCharacter = Instantiate(characters[index], transform);
        currentCharacter.transform.localPosition = Vector3.zero;
    }
}
