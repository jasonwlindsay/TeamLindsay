import * as types from '../mutation-types/appMutation'

const state = {
  storeName: 'Zach Finn Guthrie'
}

const getters = {
  storeName: state => state.storeName
}

const actions = {
  [types.UPDATE_STORE_NAME] ({ commit }, name) {
    commit(types.UPDATE_STORE_NAME, name)
  }
}

const mutations = {
  [types.UPDATE_STORE_NAME] (state, name) {
    state.storeName = name
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
