import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/components/pages/Index'
import Details from '@/components/pages/Details'
Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'Index',
      component: Index
    },
    {
      path: '/details',
      name: 'Details',
      component: Details
    }
  ]
})
