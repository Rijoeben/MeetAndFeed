<template>
  <q-card class="my-card bg-blue text-white">
    <q-card-section>
      <div class="text-h6">{{DishName}}</div>
      <div class="text-subtitle2">{{Cheff}}</div>
    </q-card-section>
    <q-separator class="sep"/>
    <q-card-actions class="buttons">
      <q-btn outline color="white">Contact</q-btn>
      <q-btn flat label="More info"></q-btn>
    </q-card-actions>
  </q-card>
</template>

<style scoped>
.my-card {
  min-width: 200px;
  max-width: 600px;
  width: 90vw;
  margin-top: 30px;
}
.buttons {
  margin-top: 0px;
}
.sep {
  background: rgba(255,255,255,0.3);
}
</style>

<script>
export default {
  name: 'FeedPost',
  props: {
    DishName: {
      type: String,
      required: true
    },

    Cheff: {
      type: String,
      required: true
    }
  }
}
</script>
