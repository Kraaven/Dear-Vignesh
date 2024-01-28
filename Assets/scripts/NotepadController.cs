using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotepadController : MonoBehaviour
{
    public TMP_Text Strawberry;
    public TMP_Text Flour;
    public TMP_Text Sugar;
    public TMP_Text Milk;
    public TMP_Text Egg;

    public void CutFlour()
    {
        Flour.fontStyle = FontStyles.Strikethrough;
        Flour.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }
    public void CutSugar()
    {
        Sugar.fontStyle = FontStyles.Strikethrough;
        Sugar.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }
    public void CutMilk()
    {
        Milk.fontStyle = FontStyles.Strikethrough;
        Milk.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }
    public void CutEgg()
    {
        Egg.fontStyle = FontStyles.Strikethrough;
        Egg.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }

    public void ConvertStrawberry()
    {
        Strawberry.text = "Chocolate";
        Strawberry.fontStyle = FontStyles.Italic;
    }

    public void CutChoco()
    {
        Strawberry.fontStyle = FontStyles.Strikethrough;
        Strawberry.gameObject.transform.GetChild(1).gameObject.SetActive(true);
    }
    
    
}
