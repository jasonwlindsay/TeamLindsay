import Vue from 'vue'
import Vuex from 'vuex'

// modules
import App from './modules/appStore'
import Meals from './modules/mealStore'

// wireup
Vue.use(Vuex)

const debug = process.env.NODE_ENV !== 'production'
var state = {}

export default new Vuex.Store({
  state,
  modules: {
    App,
    Meals
  },
  strict: debug
})
