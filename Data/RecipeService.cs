namespace WeeklyCook.Data;


public class RecipeService
{
    private static readonly string[] nonDataBaseRecipes =
    {
        "Chicken and rice",
        "Chicken soup",
        "Frozen pizza with left overs",
        "Fried rice",
        "Spaghetti",
        "Ravioli with pesto",
        "Steak and fries",
        "Beef soup",
        "Fried eggs and toast",
        "Cereal",
        "Acorn squash",
        "Lentil rice",
        "Omurice rice",
        "Quwan and carrots",
        "Frozen dumpling"
    };

    public Task<Recipe[]> GetRandomListOfRecipes(int numRecipes)
    {
        Random random = new Random();
        Recipe[] recipesList = new Recipe[numRecipes];
        for (int i = 0;i<numRecipes;i++)
        {
            recipesList[i] = recipesList[random.Next(14)];
        }
        return Task.FromResult(recipesList);
    }
    //Test code to get somthing to desplay
    public Task<Recipe[]> GetTestCodeToDisplay(int numRecipes)
    {
        Random random = new Random();
        Recipe[] recipesList = new Recipe[numRecipes];
        Recipe recipe = new Recipe();

        //string[] t = new string[numRecipes];
        //t[0] = nonDataBaseRecipes[0];
        
        recipe.Name = nonDataBaseRecipes[random.Next(14)];
        recipesList[0] = recipe;

        for (int i = 0; i < numRecipes; i++)
        {
            Recipe recipe2 = new Recipe();
            recipe2.Name = nonDataBaseRecipes[random.Next(14)];
            recipesList[i] = recipe2;
        }

        return Task.FromResult(recipesList);
    }
    public Recipe[] GetTestCodeToDisplay2(int numRecipes)
    {
        Random random = new Random();
        Recipe[] recipesList = new Recipe[numRecipes];
        Recipe recipe = new Recipe();

        //string[] t = new string[numRecipes];
        //t[0] = nonDataBaseRecipes[0];

        recipe.Name = nonDataBaseRecipes[random.Next(14)];
        recipesList[0] = recipe;

        for (int i = 0; i < numRecipes; i++)
        {
            Recipe recipe2 = new Recipe();
            recipe2.Name = nonDataBaseRecipes[random.Next(14)];
            recipesList[i] = recipe2;
        }

        return recipesList;
    }
}
