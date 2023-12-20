﻿using ChefGPT.Client.Shared;
using ChefGPT.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChefGPT.Shared;
using ChefGPT.Server.Services;
using Microsoft.Extensions.Primitives;

namespace ChefGPT.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IOpenAIAPI _openAIService;
        public RecipeController(IOpenAIAPI openAIService)
        {
            _openAIService = openAIService;
        }

        [HttpPost, Route("GetRecipeIdeas")]
        public async Task<ActionResult<List<Idea>>> GetRecipeIdeas(RecipeParms recipeParms)
        {
            string mealtime = recipeParms.MealTime;
            List<string?> ingredients = recipeParms.Ingredients
                                                  .Where(x => !string.IsNullOrEmpty(x.Description))
                                                  .Select(x => x.Description)
                                                  .ToList();
            if (string.IsNullOrEmpty(mealtime))
            {
                mealtime = "Breakfast";
            }

            var ideas = await _openAIService.CreateRecipeIdeas(mealtime, ingredients);

            return ideas;

            //return SampleData.RecipeIdeas;

        }

        [HttpPost, Route("GetRecipe")]
        public async Task<ActionResult<Recipe?>> GetRecipe(RecipeParms recipeParms)
        {
            //return SampleData.Recipe;

            List<string> ingredients = recipeParms.Ingredients
                                                    .Where(x => !string.IsNullOrEmpty(x.Description))
                                                    .Select(x => x.Description!)
                                                    .ToList();
            string? title = recipeParms.SelectedIdea;

            if (string.IsNullOrEmpty(title))
            {
                return BadRequest();
            }

            var recipe = await _openAIService?.CreateRecipe(title, ingredients);
            return recipe;
        }

        [HttpGet, Route("GetRecipeImage")]
        public async Task<RecipeImage> GetRecipeImage(string title)
        {
            //return SampleData.RecipeImage;

            var recipeImage = await _openAIService.CreateRecipeImage(title);

            return recipeImage ?? SampleData.RecipeImage;
        }

    }
    
}
