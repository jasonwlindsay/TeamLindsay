<template>
  <div>
    <h1>Meal Planning</h1>
    <div class="row form justify-content-center">
      <div class="col-2 form-inline">
        <span>Start Date:&nbsp;</span>
        <span><date-picker v-model="listSearch.StartDate" :bootstrap-styling="true"></date-picker></span>
      </div>
      <div class="col-2 form-inline">
        <span>End Date:&nbsp;</span>
        <span><date-picker v-model="listSearch.EndDate" :bootstrap-styling="true"></date-picker></span>
      </div>
      <div class="col-2 form-inline">
        <meal-types></meal-types>
      </div>
      <div class="col-2 form-inline">
        <button class="btn btn-success btn-lg" @click="searchList()">Search</button>
      </div>
    </div>
    <div class="clearfix">
      <p></p>
    </div>
    <div class="row justify-content-center">
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
import datePicker from 'vuejs-datepicker'
import mealTypes from '@/components/directives/MealTypes'

export default {
  components: {
    datePicker,
    mealTypes
  },
  computed: {
    listSearch: {
      get: function () {
        return this.$store.getters.mealListSearch
      },
      set: function (newSearch) {
        this.$store.dispatch(types.UPDATE_SEARCH, newSearch)
      }
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
  .vdp-datepicker {
     input {
       width: 125px;
      }
  }
</style>
