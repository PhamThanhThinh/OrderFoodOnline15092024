let apiURL = "https://forkify-api.herokuapp.com/api/v2/recipes";
let apikey = "10235969-e8e9-46ca-a350-7e2d62b40d41";

async function GetRecipes(recipeName, id, isAllShow) {
  let resp = await fetch(`${apiURL}?search=${recipeName}&key=${apikey}`);
  let result = await resp.json();
  let Recipes = isAllShow ? result.data.recipes : result.data.recipes.slice(0, 12);
  showRecipes(Recipes, id);
}

function showRecipes(recipes, id) {
  $.ajax({
    contentType: "application/json; charset=utf-8",
    dataType: 'html',
    type: 'POST',
    url: '/Recipe/GetRecipeCard',
    data: JSON.stringify(recipes),
    success: function (htmlResult) {
      $('#' + id).html(htmlResult);
    }
  });
}

async function getOrderRecipe(id, showId) {
  let responsive = await fetch(`${apiURL}/${id}?key=${apikey}`);
  let result = await responsive.json();
  console.log(result);
  let recipe = result.data.recipe;
  showOrderRecipeDetails(recipe, showId);
}
function showOrderRecipeDetails(data, showId) {
  console.log(data);
  $.ajax({
    contentType: "application/json; charset=utf-8",
    dataType: 'html',
    type: 'POST',
    url: '/Recipe/ShowOrder',
    data: JSON.stringify(data),
    success: function (htmlResult) {
      $('#' + showId).html(htmlResult);
    }
  });
}