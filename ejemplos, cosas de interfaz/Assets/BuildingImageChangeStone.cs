using UnityEngine;
using UnityEngine.UI;
/*
public class BuildingImageChangePopulation : MonoBehaviour
{

    public Text PopulationText;
    public Sprite[] PopulationBuildings;
    public double Population = 0;
    public double PopulationProduction = 0.1;
    public double PopulationBuildingCost = 100;
    public int PopulationBuildingQuantity = 1;


    public void PopulationBuildingUpgrade()
    {
        if (Population - PopulationBuildingCost > 0)
        {
            Population = Population - PopulationBuildingCost;
            PopulationProduction = PopulationProduction + 0.1;
            PopulationBuildingCost = PopulationBuildingCost * 1.1;
            PopulationBuildingQuantity++;
            switch (PopulationBuildingQuantity)
            {
                case 10:
                    this.GetComponent<Image>().sprite = PopulationBuildings[1];
                    break;

                case 20:
                    this.GetComponent<Image>().sprite = PopulationBuildings[2];
                    break;

                default:
                    Debug.Log("test");
                    break;

            }
            return;
        }



    }


    private void Update()
    {

    }
    private void LateUpdate()
    {
        Population = Population + PopulationProduction;
        string Populationsci = Population.ToString("0.00E+0");
        PopulationText.text = "Population" + ":" + Populationsci;
    }


}
*/