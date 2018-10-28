// resources/assets/js/vuex/utils/api.js
import axios from 'axios'
// import Vue from 'vue'
let baseUrl = 'http://localhost:56841'
const baseApi = axios.create({
  baseURL: baseUrl,
  headers: {
    'Content-Type': 'application/json',
    'Accept': 'application/json'
  }
})

export default {
  get (url, request) {
    return baseApi.get(url, request)
      .then((response) => Promise.resolve(response.body.data))
      .catch((error) => Promise.reject(error))
  },
  post (url, request) {
    return baseApi.post(url, request)
      .then((response) => Promise.resolve(response))
      .catch((error) => Promise.reject(error))
  },
  put (url, request) {
    return baseApi.put(url, request)
      .then((response) => Promise.resolve(response))
      .catch((error) => Promise.reject(error))
  },
  delete (url, request) {
    return baseApi.delete(url, request)
      .then((response) => Promise.resolve(response))
      .catch((error) => Promise.reject(error))
  }
}
