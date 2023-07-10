using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;
using CookieCookbook.App;
using CookieCookbook.Tools.DataAccess;
using CookieCookbook.Tools.FileFormatting;

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