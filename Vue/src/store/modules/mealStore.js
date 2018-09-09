import * as types from '../mutation-types/mealMutation'
import { resolve } from 'path';

const state = {
  mealList: []
}

const getters = {
  mealList: state => state.mealList
}

const actions = {
  [types.LIST_MEALS] ({ commit }, search) {
    return new Promise((resolve, reject) => {
      this.$http.post('/meals/v1/list', search)
        .then(function(response) {
          commit(types.LIST_MEALS, search)
        })
    }).then(() => {
      resolve()
    })
  }
}

const mutations = {
  [types.LIST_MEALS] (state, search) {
    state.mealList = search
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
