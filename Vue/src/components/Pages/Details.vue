<template>
  <div>
     <div class="jumbotron">
      <h1>DETAILS</h1>
    </div>
    <p>Existing Name Attribute {{ storeName }}</p>
    <p></p>
    <input type="text" v-model="newName" placeholder="Enter another name"/>
    <p></p>
    <button class="btn btn-lg btn-danger" @click="updateStoreName()">
      Update
    </button>
  </div>
</template>
<script>
import * as types from '@/store/mutation-types/appMutation'

export default {
  data: function () {
    return {
      newName: 'JAVIER'
    }
  },
  computed: {
    storeName () {
      return this.$store.getters.storeName
    }
  },
  methods: {
    updateStoreName () {
      this.$store.dispatch(types.UPDATE_STORE_NAME, this.newName)
    }
  }

}
</script>
<style lang="scss" scoped>

</style>
