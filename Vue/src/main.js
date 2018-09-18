// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import store from '@/store'
import moment from 'moment'

Vue.config.productionTip = false

Vue.filter('shortDate', function (value) {
  if (value) {
    return moment(String(value)).format('MM/DD/YYYY')
  }
})

var VueResource = require('vue-resource')
Vue.use(VueResource)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  store,
  router,
  components: { App },
  template: '<App/>'
})
