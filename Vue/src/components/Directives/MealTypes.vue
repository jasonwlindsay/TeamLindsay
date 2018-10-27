<template>
  <div>
    <b-form-group>
      <b-form-checkbox-group buttons v-model="mealTypes" :options="mealTypeList" name="mealTypesRadioGroup">
      </b-form-checkbox-group>
    </b-form-group>
  </div>
</template>

<script>
import bFormGroup from '@/../node_modules/bootstrap-vue/src/components/form-group/form-group'
import bFormCheckboxGroup from '@/../node_modules/bootstrap-vue/src/components/form-checkbox/form-checkbox-group'
import * as types from '@/store/mutation-types/mealMutation'

export default {
  components: {
    bFormGroup,
    bFormCheckboxGroup
  },
  computed: {
    mealTypes: {
      get () {
        return this.$store.getters.mealSearchMealTypeIds
      },
      set (newValue) {
        if (newValue) {
          this.$store.dispatch(types.UPDATE_SEARCH_MEAL_TYPES, newValue)
        }
      }
    }
  },
  data () {
    return {
      mealTypeList: [
        {
          value: 1,
          text: 'Breakfast'
        },
        {
          value: 2,
          text: 'Lunch'
        },
        {
          value: 3,
          text: 'Dinner'
        }
      ]
    }
  }
}
</script>

<style lang="scss">

</style>
