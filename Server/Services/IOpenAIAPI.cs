using ChefGPT.Client.Shared;
using ChefGPT.Shared;

namespace ChefGPT.Server.Services
{
    public interface IOpenAIAPI
    {
        Task<List<Idea>> CreateRecipeIdeas(string mealtime, List<string> ingredients);

        Task<List<Idea>> CreateGlutenFreeRecipeIdeas(string mealtime, List<string> ingredients);

        Task<Recipe?> CreateRecipe(string title, List<string> ingredients);

        Task<Recipe?> CreateGlutenFreeRecipe(string title, List<string> ingredients);

        Task<RecipeImage?> CreateRecipeImage(string recipeTitle);

        /*Task<RecipeImage?> CreateGlutenFreeRecipeImage(string recipeTitle);*/
    }
}
