using ChefGPT.Client.Shared;
using ChefGPT.Shared;
using System.Reflection;

namespace ChefGPT.Server.Data
{
    public static class SampleData
    {
        public static List<Idea> RecipeIdeas = new()
        {
            new Idea
            {
                index = 0,
                title = "Chocolate Chip Cookies",
                description = "Delicious chocolate chip cookies made with browned butter"
            },
            new Idea
            {
                index = 1,
                title = "Peanut Butter Cookies",
                description = "Cookies made with peanut butter and butterscotch chips. Yum!"
            },
            new Idea {
                index = 2,
                title = "Snickerdoodles",
                description = "Classic snickerdoodle cookies. The secret ingredient is cream of tartar!"
            },
            new Idea {
                index = 2,
                title = "Sugar Cookies",
                description = "A sugar cookie is a cookie with the main ingredients being sugar, flour, butter, eggs, vanilla, and either baking powder or baking soda."
            },
            new Idea {
                index = 2,
                title = "Ginger Snaps",
                description = "Ginger snaps are a classic favorite. With just a few ingredients and even fewer steps this recipe for fabulous, spicy cookies is truly a snap to make."
            },
        };

        public static Recipe Recipe = new()
        {
            title = "Ginger Snaps",
            summary = "Ginger Snaps are a delicious treat.",
            ingredients = new[]
            {
                "1 cup flour",
                "1 cup sugar",
                "2 lbs ginger",
            },
            instructions = new[]
            {
                "M - I - X the flour into bowl.",
                "In the rain or in the snow,",
                "Got tha funky funky flow.",
            }
        };

        public static RecipeImage RecipeImage = new()
        {
            data = new ImageData[] {

                new ImageData()
                    {
                        url = "https://www.shutterstock.com/shutterstock/photos/212023036/display_1500/stock-photo-a-group-of-ginger-snaps-212023036.jpg"
                    }
            }
        };
    }
}
