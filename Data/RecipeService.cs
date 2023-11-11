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
    public Task<Recipe> GetTestCodeToDisplay(int numRecipes)
    {
        Random random = new Random();
        Recipe[] recipesList = new Recipe[numRecipes];
        Recipe recipe = new Recipe();

        //string[] t = new string[numRecipes];
        //t[0] = nonDataBaseRecipes[0];
        for(int i = 0; i < numRecipes; i++)
        {
      //      recipesList[i].Name = nonDataBaseRecipes[i];
        }
        recipe.Name = nonDataBaseRecipes[random.Next(14)];
        //recipesList[0] = recipe;

        return Task.FromResult(recipe);
    }
}
