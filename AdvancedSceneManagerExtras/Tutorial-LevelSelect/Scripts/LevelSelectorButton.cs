using AdvancedSceneManager.Models;
using AdvancedSceneManager.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectorButton : MonoBehaviour
{
    public Image image;
    public Text description;
    SceneCollection collection;

    public void OpenLevel()
    {
        SceneHelperUtility.Current.Open(collection);
    }

    public void ApplyData(Sprite thumbnail, string text, SceneCollection collection)
    {
        image.sprite = thumbnail;
        description.text = text;
        this.collection = collection;
    }
}
