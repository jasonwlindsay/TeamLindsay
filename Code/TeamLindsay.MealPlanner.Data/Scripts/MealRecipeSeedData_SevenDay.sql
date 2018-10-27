use MealPlanner
go

delete from MealRecipes
delete from Recipes
delete from Meals
dbcc checkident(Recipes, reseed, 0)
dbcc checkident(Meals, reseed, 0)
go

--dbcc checkident(Recipes, noreseed)
--dbcc checkident(Meals, noreseed)

insert into Recipes (Name, Ingredients, Instructions)
	values ('Chicken Lo Mein', 'Chicken, Noodles', 'Do This')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Fried Eggs', 'Eggs', 'Do This')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Spaghetti', 'Pasta, Tomato Sauce', 'Do This')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Hamburgers', 'Ground Beef, Buns', 'Do This')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Crepes', 'batter', 'crepe pan and love')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Fried Chicken', 'Chicken and other stuff', 'Make it like this')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Tacos', 'Ground Turkey, Beans, Tortillas', 'Brown meat and season')

insert into Recipes (Name, Ingredients, Instructions)
	values ('Broccoli and Penne Chicken', 'Chicken, Broccoli, Penne Pasta, Mayo', 'Cook it up')


declare @daysIncrement int = 10	
declare @startDate datetime = getdate()
declare @endDate datetime = dateadd(day, @daysIncrement, @startDate)

declare @count int = 0
declare @recipeCounter int = 1

while (@count <= @daysIncrement)
begin
	declare @mealDate datetime = dateadd(day, @count, @startDate)
	print 'Meal Date ' + cast(@mealDate as nvarchar(20))

	insert into Meals (MealDate, MealTypeId) values (@mealDate, 1)
	declare @mealId int = scope_identity()

	if not exists (select Id from Recipes where Id = @recipeCounter)
		set @recipeCounter = 1

	insert into MealRecipes (MealId, RecipeId) values (@mealId, @recipeCounter)
	set @recipeCounter = @recipeCounter + 1

	print 'Meal inserted' 
	insert into Meals (MealDate, MealTypeId) values (@mealDate, 3)
	set @mealId = scope_identity()

	if not exists (select Id from Recipes where Id = @recipeCounter)
		set @recipeCounter = 1
	insert into MealRecipes (MealId, RecipeId) values (@mealId, @recipeCounter)
	set @recipeCounter = @recipeCounter + 1

	print 'Meal inserted' 

	set @count = @count + 1
	print 'Incremented ' + cast(@count as nvarchar(10))
end

