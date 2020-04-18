<template>
    <div class="q-pa-md" style="max-width: 400px">
        <div class="row justify-center">
            <h5>Create Post</h5>
        </div>
        <q-form
      @submit="onSubmit"
      @cancel="onCancel"
      class="q-gutter-md"
    >
      <q-input
        filled
        v-model="name"
        label="Name of the dish"
      />
      <h6>
        Allergies
      </h6>
      <div class="full-width row wrap justify-evenly items-start content-start allergies-checkbox-container">
          <q-checkbox v-model="milk" label="Milk" />
          <q-checkbox v-model="eggs" label="Eggs" />
          <q-checkbox v-model="nuts" label="Nuts" />
          <q-checkbox v-model="shellfish" label="Shellfish" />
          <q-checkbox v-model="fish" label="Fish" />
      </div>
      <q-input
        v-model="text"
        filled
        type="textarea"
        label="Description"
      />
      <div>
        <q-btn label="Create post" type="submit" color="primary"/>
        <q-btn label="Cancel" type="cancel" color="primary" @click="Cancel" flat class="q-ml-sm" />
      </div>
    </q-form>
    </div>
</template>
<style scoped>
h5 {
    color: #4A9DFF;
    margin: 0 0 20px 0;
}
h6 {
    color: #4A9DFF;
    font-size: 1.2em;
    margin-bottom: 0;
}
.allergies-checkbox-container {
    margin-top: 0;
}
</style>

<script>
export default {
  name: 'CreatePost',
  data () {
    return {
      milk: false,
      eggs: false,
      nuts: false,
      shellfish: false,
      fish: false
    }
  },
  methods: {
    Cancel () {
      this.$router.push({ name: 'feed' })
    }
  }
}
</script>
