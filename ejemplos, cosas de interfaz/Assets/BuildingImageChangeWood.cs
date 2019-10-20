using UnityEngine;
using UnityEngine.UI;

public class BuildingImageChangeWood : MonoBehaviour
{
    //TechStuff
    public Button[] TechButtons; // 0: ReTech ;
    public double[] TechValuablesCostDouble; // 0: Retech... 
    public Text[] TechValuablesCostText; // 0: Retech...same as above
    public int[] Techlevels; // 0: Retech...
    public double[] TechEffectTextDouble;
    public Text[] TechEffectText; // 0: Retech...
    
    

    //PillageStuff

    public double valuables = 0;
    public Slider basicSoldierPillageSlider;
    public Text ValuablesText;
    

    //SoldierStuff

    public Slider basicSoldierSlider;
    public Text currentBasicSoldierText;
    public double currentBasicSoldierCount;
    public double basicSoldierQuantity;



    public Image[] imagesToChange;  //0: Wood ; 1: Stone ; 2: Food ; 3: Housing

    //WoodStuff
    public Text WoodText;
    public Sprite[] WoodBuildings;
    public double Wood = 0;
    public double WoodProduction = 10;
    public double WoodBuildingCost = 100;
    public int woodBuildingQuantity = 1;

    //StoneStuff
    public Text StoneText;
    public Sprite[] StoneBuildings;
    public double Stone = 0;
    public double StoneProduction = 10;
    public double StoneBuildingCost = 100;
    public int StoneBuildingQuantity = 1;

    //FoodStuff
    public Text FoodText;
    public Sprite[] FoodBuildings;
    public double Food = 0;
    public double FoodProduction = 10;
    public double FoodBuildingCost = 100;
    public int FoodBuildingQuantity = 1;

    //PopulationStuff
    public Text PopulationText;
    public Sprite[] PopulationBuildings;
    public double Population = 0;
    public double PopulationProduction = 3;
    public double PopulationBuildingCost = 100;
    public int PopulationBuildingQuantity = 1;

    //Buildings Stuff

    public void WoodBuildingUpgrade()
    {
        if (Wood - WoodBuildingCost > 0)
        {
            Wood = Wood - WoodBuildingCost;
            WoodProduction = WoodProduction + 0.15;
            WoodBuildingCost = WoodBuildingCost * 1.1;
            woodBuildingQuantity++;
            switch (woodBuildingQuantity)
            {
                case 5:

                    imagesToChange[0].sprite = WoodBuildings[1];
                    break;

                case 10:
                    imagesToChange[0].sprite = WoodBuildings[2];
                    break;

                default:
                    break;

            }

        }
    }


    public void StoneBuildingUpgrade()
    {
        if ((Stone - StoneBuildingCost > 0) && (Wood - StoneBuildingCost > 0))
        {
            Stone = Stone - StoneBuildingCost;
            Wood = Wood - StoneBuildingCost;
            StoneProduction = StoneProduction + 0.12;
            StoneBuildingCost = StoneBuildingCost * 1.1;
            StoneBuildingQuantity++;
            switch (StoneBuildingQuantity)
            {
                case 5:
                    imagesToChange[1].sprite = StoneBuildings[1];
                    break;

                case 10:
                    imagesToChange[1].sprite = StoneBuildings[2];
                    break;

                default:
                    break;

            }

        }

    }

    public void FoodBuildingUpgrade()
    {
        if ((Wood - FoodBuildingCost > 0) && (Stone - FoodBuildingCost > 0))
        {
            Wood = Food - FoodBuildingCost;
            Stone = Food - FoodBuildingCost;
            FoodProduction = FoodProduction + 0.1;
            FoodBuildingCost = FoodBuildingCost * 1.1;
            FoodBuildingQuantity++;
            switch (FoodBuildingQuantity)
            {
                case 5:
                    imagesToChange[2].sprite = FoodBuildings[1];
                    break;

                case 10:
                    imagesToChange[2].sprite = FoodBuildings[2];
                    break;

                default:
                    break;

            }

        }
    }

    public void PopulationBuildingUpgrade()
    {
        if ((Wood - PopulationBuildingCost > 0) && (Stone - PopulationBuildingCost > 0) && (Food - PopulationBuildingCost > 0))
        {
            Wood = Wood - PopulationBuildingCost;
            Stone = Stone - PopulationBuildingCost;
            Food = Food - PopulationBuildingCost;
            PopulationProduction = PopulationProduction + 0.1;
            PopulationBuildingCost = PopulationBuildingCost * 1.1;
            PopulationBuildingQuantity++;
            switch (PopulationBuildingQuantity)
            {
                case 5:
                    imagesToChange[3].sprite = PopulationBuildings[1];
                    break;

                case 10:
                    imagesToChange[3].sprite = PopulationBuildings[2];
                    break;

                default:
                    break;

            }
            return;
        }
    }

    //Army Stuff

    public void HireBasicSoldier()
    {
      
        double tempdouble1 = basicSoldierSlider.value;
        if (Population > tempdouble1)
        {
            Population = Population - tempdouble1;
            basicSoldierQuantity = basicSoldierQuantity + tempdouble1;
            currentBasicSoldierText.text = tempdouble1.ToString("0.00E+0");
            currentBasicSoldierCount = tempdouble1 + currentBasicSoldierCount;
            currentBasicSoldierText.text = currentBasicSoldierCount.ToString("0.00E+0");
        }
    }

    //Pillage Stuff

    public void addPillageResources()
    {
        if (basicSoldierQuantity >= basicSoldierPillageSlider.value)
        {
            double tempdouble2 = basicSoldierPillageSlider.value;
            valuables = valuables + tempdouble2;
            string tempString = valuables.ToString("0.00E+0");
            ValuablesText.text = "Valuables: " + tempString;
        }
    }

    //Tech Stuff

    public void levelReTech() //better resource production
    {
        if(valuables >= TechValuablesCostDouble[0]) { 
        valuables = valuables - TechValuablesCostDouble[0];
        TechValuablesCostDouble[0] = TechValuablesCostDouble[0] * 1.2;
        Techlevels[0] = Techlevels[0] + 1;
        TechValuablesCostText[0].text = TechValuablesCostDouble[0].ToString("0.00E+0");
        ValuablesText.text = "Valuables:" + valuables.ToString("0.00E+0");
        
         
        }
    }

    public void levelArtech()
    {
        if (valuables >= TechValuablesCostDouble[1])
        {
            valuables = valuables - TechValuablesCostDouble[1];
            TechValuablesCostDouble[1] = TechValuablesCostDouble[1] * 1.5;
            Techlevels[1] = Techlevels[1] + 1;
            TechValuablesCostText[1].text = TechValuablesCostDouble[1].ToString("0.00E+0");
            ValuablesText.text = "Valuables:" + valuables.ToString("0.00E+0");
            basicSoldierSlider.maxValue = basicSoldierSlider.maxValue + (basicSoldierSlider.maxValue * Techlevels[1]/10 ) ;
        }
    }

    private void LateUpdate()
    {

        Wood = Wood + WoodProduction + (WoodProduction * (Techlevels[0]/20));
        string Woodsci = Wood.ToString("0.00E+0");
        WoodText.text = "Wood" + ":" + Woodsci;

        Stone = Stone + StoneProduction + (StoneProduction * (Techlevels[0] / 20));
        string Stonesci = Stone.ToString("0.00E+0");
        StoneText.text = "Stone" + ":" + Stonesci;

        Food = Food + FoodProduction + (FoodProduction * (Techlevels[0] / 20));
        string Foodsci = Food.ToString("0.00E+0");
        FoodText.text = "Food" + ": " + Foodsci;

        Population = Population + PopulationProduction;
        string Populationsci = Population.ToString("0.00E+0");
        PopulationText.text = "Population" + ":" + Populationsci;
    }

}
    


