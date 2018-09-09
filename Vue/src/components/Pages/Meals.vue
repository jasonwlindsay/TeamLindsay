<template>
  <div>
    <h1>Meal Planning</h1>
    <div class="row justify-content-center">
      FILTERS
    </div>
    <div class="row justify-content-center">
      <div class="col-6 align-center text-center">
        <table class="table table-striped table-sm table-bordered">
          <thead class="thead-dark">
            <tr>
              <th>Meal Date</th>
              <th>Meal Type</th>
              <th>Recipe</th>
            </tr>
          </thead>
          <tr>
            <td>1</td>
            <td>2</td>
            <td>3</td>
          </tr>
        </table>
      </div>
    </div>
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
