import Vue from 'vue'
import Router from 'vue-router'
import Meals from '@/components/pages/Meals'
import Recipes from '@/components/pages/Recipes'
Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Meals',
      component: Meals
    },
    {
      path: '/recipes',
      name: 'Recipes',
      component: Recipes
    }
  ]
})
