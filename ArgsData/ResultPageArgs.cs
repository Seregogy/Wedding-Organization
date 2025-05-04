using WeddingOrganization.Helpers;
using Windows.UI.Xaml;

namespace WeddingOrganization.ArgsData
{
    public class ResultPageArgs
    {
        public int GuestCount { get; set; }
        public string BudgetType { get; set; }
        public string CelebrationPlace { get; set; }

        public Visibility Fabrics { get; set; }
        public Visibility Dishes { get; set; }
        public Visibility Furniture { get; set; }
        public Visibility Decor { get; set; }

        public Visibility LightProducer { get; set; }
        public Visibility Show { get; set; }
        public Visibility CoverGroup { get; set; }
        public Visibility FirstDance { get; set; }
        public Visibility Firework { get; set; }
        public Visibility FireShow { get; set; }

        public Visibility PhotoZone { get; set; }
        public Visibility VideoGraph { get; set; }

        public int CalculateTotalCost()
        {
            return
                GetCurrentBudgetTypeCost() +
                GetCurrentCelebrationPlaceCost() +
                CalculateMain() +
                CalculateDecor() + 
                CalculateShow() +
                CalculateAdditional();
        }

        public int CalculateMain()
        {
            return
                GuestCount * 2000 +
                GetCurrentBudgetTypeCost();
        }

        public int CalculateDecor()
        {
            return
                215000 +
                10000 * (Fabrics.ToBoolean() ? 1 : 0) +
                7500 * (Dishes.ToBoolean() ? 1 : 0) +
                10000 * (Furniture.ToBoolean() ? 1 : 0);

        }

        public int CalculateShow()
        {
            return
                100000 +
                80000 * (LightProducer.ToBoolean() ? 1 : 0) +
                25000 * (Show.ToBoolean() ? 1 : 0) +
                100000 * (CoverGroup.ToBoolean() ? 1 : 0) +
                10000 * (FirstDance.ToBoolean() ? 1 : 0) +
                70000 * (Firework.ToBoolean() ? 1 : 0) +
                70000 * (FireShow.ToBoolean() ? 1 : 0);
        }

        public int CalculateAdditional()
        {
            return
                100000 +
                30000 * (PhotoZone.ToBoolean() ? 1 : 0) +
                80000 * (VideoGraph.ToBoolean() ? 1 : 0);
        }

        public int GetCurrentBudgetTypeCost()
        {
            switch (BudgetType)
            {
                case "Базовый":
                    return 100000;

                case "Продвинутый":
                    return 200000;

                case "Премиальный":
                    return 500000;

                default:
                    return 0;
            }
        }

        public int GetCurrentCelebrationPlaceCost()
        {
            switch (CelebrationPlace)
            {
                case "Ресторан":
                    return 500000;

                case "Усадьба":
                    return 700000;

                default:
                    return 0;
            }
        }
    }
}