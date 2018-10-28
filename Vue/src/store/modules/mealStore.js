import api from '../utils/api.js'
import * as types from '../mutation-types/mealMutation'

const state = {
  mealListResults: [],
  mealListSearch: {}
}

const getters = {
  mealListResults: state => state.mealListResults,
  mealListSearch: state => state.mealListSearch,
  mealSearchMealTypeIds: state => state.mealListSearch.MealTypeIds
}

const actions = {
  [types.UPDATE_SEARCH] ({ commit }, search) {
    commit(types.UPDATE_SEARCH, search)
  },
  [types.LIST_MEALS] ({ commit }) {
    return api.post('http://localhost:56841/meals/v1/list', state.mealListSearch)
      .then(function (response) {
        commit(types.UPDATE_SEARCH, response.data.Search)
        commit(types.UPDATE_MEAL_RESULTS, response.data.Results)
      })
  },
  [types.UPDATE_SEARCH_MEAL_TYPES] ({ commit }, mealTypes) {
    commit(types.UPDATE_SEARCH_MEAL_TYPES, mealTypes)
  }
}

const mutations = {
  [types.UPDATE_MEAL_RESULTS] (state, results) {
    state.mealListResults = results
  },
  [types.UPDATE_SEARCH] (state, search) {
    state.mealListSearch = search
  },
  [types.UPDATE_SEARCH_MEAL_TYPES] (state, mealTypes) {
    state.mealListSearch.MealTypeIds = mealTypes
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
