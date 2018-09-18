import api from '../utils/api.js'
import * as types from '../mutation-types/mealMutation'
// import Vue from 'vue'

const state = {
  mealListResults: [],
  mealListSearch: {}
}

const getters = {
  mealListResults: state => state.mealListResults,
  mealListSearch: state => state.mealListSearch
}

const actions = {
  [types.LIST_MEALS] ({ commit }, search) {
    console.log('inside LIST_MEALS')
    return api.post('http://localhost:56841/meals/v1/list', search)
      .then(function (response) {
        commit(types.UPDATE_SEARCH, response.data.Search)
        commit(types.LIST_MEALS, response.data.Results)
      })
  }
}

const mutations = {
  [types.LIST_MEALS] (state, results) {
    state.mealListResults = results
  },
  [types.UPDATE_SEARCH] (state, search) {
    state.mealListSearch = search
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
