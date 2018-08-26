use MealPlanner
go

delete from MealRecipes
delete from Meals
delete from Recipes

go

insert into Recipes (Name, Ingredients, Instructions)
	values ('Crepes', 'batter', 'crepe pan and love')
declare @crepes int = scope_identity()

insert into Recipes (Name, Ingredients, Instructions)
	values ('Fried Chicken', 'Chicken and other stuff', 'Make it like this')
declare @friedChicken int = scope_identity()

insert into Recipes (Name, Ingredients, Instructions)
	values ('Tacos', 'Ground Turkey, Beans, Tortillas', 'Brown meat and season')
declare @tacos int = scope_identity()

insert into Recipes (Name, Ingredients, Instructions)
	values ('Broccoli and Penne Chicken', 'Chicken, Broccoli, Penne Pasta, Mayo', 'Cook it up')
declare @penne int = scope_identity()

insert into Meals (MealDate, MealTypeId)
	values ('2018-10-01', 1)
insert into MealRecipes (MealId, RecipeId)
	values (scope_identity(), @crepes)

insert into Meals (MealDate, MealTypeId)
	values ('2018-10-01', 3)
insert into MealRecipes (MealId, RecipeId)
	values (scope_identity(), @tacos)

insert into Meals (MealDate, MealTypeId)
	values ('2018-10-02', 1)
insert into MealRecipes (MealId, RecipeId)
	values (scope_identity(), @penne)

insert into Meals (MealDate, MealTypeId)
	values ('2018-10-02', 3)
insert into MealRecipes (MealId, RecipeId)
	values (scope_identity(), @friedChicken)
go

create or alter view MealRecipeListView
as
	select 
		m.Id MealId,
		m.MealDate,
		mt.Id MealTypeId,
		mt.Name MealType,
		r.Id RecipeId,
		r.Name RecipeName,
		r.Ingredients Ingredients,
		r.Instructions Instructions
	from Meals m
		join MealTypes mt on m.MealTypeId = mt.Id
		join MealRecipes x on m.Id = x.MealId
		join Recipes r on x.RecipeId = r.Id
go

select * 
from MealRecipeListView
