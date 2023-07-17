using CookieCookbookWithLinq.Recipes;
using CookieCookbookWithLinq.Recipes.Ingredients;
using CookieCookbookWithLinq.App;
using CookieCookbookWithLinq.Tools.DataAccess;
using CookieCookbookWithLinq.Tools.FileFormatting;

const FileFormat Format = FileFormat.Json;

IStringsRepository stringsRepository = Format == FileFormat.Json ?
	new StringsJsonRepository() : new StringsTextFileRepository();

const string FileName = "recipes";
var fileTypedata = new FileTypedata(FileName, Format);

var ingredientRegister = new IngredientRegister();

var cookiesRecipesApp = new CookiesRecipeApp(
	new RecipeRepository(stringsRepository, ingredientRegister),
	new RecipeUserInteraction(ingredientRegister));

cookiesRecipesApp.Run(fileTypedata.ToPath());