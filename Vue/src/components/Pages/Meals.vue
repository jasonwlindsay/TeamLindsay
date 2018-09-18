<template>
  <div>
    <h1>Meal Planning</h1>
    <div class="row justify-content-center">
      <div class="col-3">
        <date-picker v-model="search.StartDate"></date-picker>
      </div>
    </div>
    <div class="row justify-content-center">
      <!-- <div class="col-3">

      </div> -->
      <div class="col-6 align-center text-center">
        <table class="table table-striped table-sm table-bordered">
          <thead class="thead-dark">
            <tr>
              <th>Meal Date</th>
              <th>Meal Type</th>
              <th>Recipe</th>
            </tr>
          </thead>
          <tr v-for="meal in listResults" v-bind:key="meal.MealId">
            <td>{{ meal.MealDate | shortDate }}</td>
            <td>{{meal.MealType}}</td>
            <td>{{meal.RecipeName}}</td>
          </tr>
        </table>
      </div>
    </div>
  </div>
</template>
<script>
import * as types from '@/store/mutation-types/mealMutation'
import datePicker from 'vue-bootstrap-datetimepicker'

export default {
  // data: function () {
  //   return {
  //     searchParams: {}
  //   }
  // },
  components: {
    datePicker
  },
  computed: {
    search () {
      return this.$store.getters.mealListSearch
    },
    listResults () {
      return this.$store.getters.mealListResults
    }
  },
  methods: {
    searchList () {
      this.$store.dispatch(types.LIST_MEALS)
    }
  },
  mounted: function () {
    this.$store.dispatch(types.LIST_MEALS, null)
  }

}
</script>
<style lang="scss" scoped>

</style>
