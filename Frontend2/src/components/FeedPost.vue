<template>
  <q-card class="my-card">
    <q-card-section>
      <div class="text-h6">{{DishName}}</div>
      <div class="text-subtitle2">{{Cheff}}</div>
    </q-card-section>
    <q-card-actions class="buttons">
      <q-btn outline color="primary">Contact</q-btn>
      <q-btn flat color="secondary" label="More info"></q-btn>
    </q-card-actions>
  </q-card>
</template>

<style scoped>
.my-card {
  min-width: 200px;
  max-width: 600px;
  width: 90vw;
  margin-top: 30px;
  margin-right: 5px;
  background-color: #F5F5F5;
  border-left: 5px solid #4A9DFF;
  box-shadow: 0px 0px 10px 0px rgba(136,136,136,0.3);
}
.text-h6 {
  color: #4A9DFF;
}
.text-subtitle2 {
  color: #4A4A4A;
}
.buttons {
  margin-top: 0px;
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
