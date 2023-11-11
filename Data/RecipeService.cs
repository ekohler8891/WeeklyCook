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
    public Task<Recipe[]> GetRandomListOfRecipes2(int numRecipes)
    {
       
        Recipe[] recipesList = new Recipe[numRecipes];
        
        return Task.FromResult(recipesList);
    }
}
