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
    //Get Recipe by id
    public Recipe[] GetRecipe(int recipeID)
    {
        var maxRecipeList = 1;
        Recipe[] recipes = new Recipe[maxRecipeList];
    //    var client = new HttpClient();
      //  var request = new HttpRequestMessage();
    //    request.Method = HttpMethod.Get;
    //    request.RequestUri = new Uri($"https://localhost:7232/weaklycooking/recipe?lookback={10}&enddate={DateTime.Today.ToString()}"); ;

//        request.Content = new StringContent("[]");
 //       var response = client.SendAsync(request).Result;

   //     var body = response.Content.ReadAsStringAsync().Result;
        var client = new HttpClient();
        var request = new HttpRequestMessage();
        request.Method = HttpMethod.Get;
//        request.RequestUri = new Uri("https://localhost:7232/weaklycooking/recipe/2");
        request.RequestUri = new Uri($"https://localhost:7232/weaklycooking/recipe/{recipeID}");


        request.Content = new StringContent("[]");
        var response = client.SendAsync(request).Result;

        var body = response.Content.ReadAsStringAsync().Result;
        Recipe recipe = new Recipe();
        recipe.Name = body; 

        recipes[0] = recipe;

        return recipes;
    }
}
