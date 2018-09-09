// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import VueAnalytics from 'vue-analytics'
import App from './App'
import router from './router'
import store from '@/store'

Vue.config.productionTip = false

Vue.use(VueAnalytics, {
  id: 'UA-12345678-1',
  autoTracking: {
    screenview: true
  },
  router
})

/* eslint-disable no-new */
new Vue({
  el: '#app',
  store,
  router,
  components: { App },
  template: '<App/>'
})
