namespace FitnessApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Category
        {
            public const int CategoryNameMaxLength = 50;
            public static int CategoryNameMinLength = 2;
        }

        public static class Product
        {
            public const int ProductNameMaxLength = 50;
            public const int ProductNameMinLength = 3;

            public const int ProductDescriptionMaxLength = 300;
            public const int ProductDescriptionMinLength = 10;
        }

        public static class Review
        {
            public const int ReviewTextMaxLength = 300;
            public const int ReviewTextMinLength = 10;

            public const int ReviewRatingMaxValue = 5;
            public const int ReviewRatingMinValue = 0;
        }

        public static class Program
        {
            public const int ProgramNameMaxLength = 50;
            public const int ProgramNameMinLength = 2;

            public const int ProgramDescriptionMaxLength = 300;
            public const int ProgramDescriptionMinLength = 10;

            public const int ProgramPictureUrlMaxLength = 2083;
        }

        public static class FoodRecipe
        {
            public const int FoodRecipieNameMaxLength = 50;
            public const int FoodRecipieNameMinLength = 5;

            public const int FoodRecipieIngredientsMaxLength = 300;
            public const int FooodRecipieIngredientsMinLength = 5;

            public const int FoodRecipieMethodToMakeMaxLength = 600;
            public const int FoodRecipieMethodToMakeMinLength = 50;
        }

        public static class Post
        {
            public const int PostTitleMaxLength = 30;
            public const int PostTitleMinLength = 5;

            public const int PostTextMaxLength = 2500;
            public const int PostTextMinLength = 100;
        }

    }
}