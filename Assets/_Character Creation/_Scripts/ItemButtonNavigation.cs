using UnityEngine;

public class ItemButtonNavigation : MonoBehaviour
{
    [Header(" User Interface ")]
    [SerializeField] private MaleCanvas maleCanvas;
    [SerializeField] private FemaleCanvas femaleCanvas;

    
    public void OpenPanel(GameObject desireCanvas)
    {
        CloseMaleCanvas();
        CloseFemaleCanvas();

        desireCanvas.SetActive(true);
    }

    public void CloseMaleCanvas()
    {
        maleCanvas.tShirtCanvas.SetActive(false);
        maleCanvas.trouserCanvas.SetActive(false);
        maleCanvas.hairCanvas.SetActive(false);
        maleCanvas.facialHairCanvas.SetActive(false);
        maleCanvas.hatCanvas.SetActive(false);
        maleCanvas.footwearCanvas.SetActive(false);
        maleCanvas.sunglassesCanvas.SetActive(false);
    }

    public void CloseFemaleCanvas()
    {
        femaleCanvas.tShirtCanvas.SetActive(false);
        femaleCanvas.trouserCanvas.SetActive(false);
        femaleCanvas.hairCanvas.SetActive(false);
        femaleCanvas.hatCanvas.SetActive(false);
        femaleCanvas.footwearCanvas.SetActive(false);
        femaleCanvas.sunglassesCanvas.SetActive(false);
    }
}

[System.Serializable]
public class MaleCanvas
{
    public GameObject tShirtCanvas;
    public GameObject trouserCanvas;
    public GameObject hairCanvas;
    public GameObject facialHairCanvas;
    public GameObject hatCanvas;
    public GameObject footwearCanvas;
    public GameObject sunglassesCanvas;
}


[System.Serializable]
public class FemaleCanvas
{
    public GameObject tShirtCanvas;
    public GameObject trouserCanvas;
    public GameObject hairCanvas;
    public GameObject hatCanvas;
    public GameObject footwearCanvas;
    public GameObject sunglassesCanvas;
}