<template>
    <q-expansion-item dense class="bg-F6F6F6 exp-item">
        <template v-slot:header>
          <q-item-section class="title">
            {{question}}
          </q-item-section>
        </template>

        <q-card class="bg-F6F6F6 text">
          <q-card-section style="padding-top: 0; padding-bottom: 0;">
            {{answer}}
          </q-card-section>
        </q-card>
      </q-expansion-item>
</template>

<style scoped>
.exp-item {
    width: 95vw;
    border-left: 3px solid #4A9DFF;
    padding: 4px 0px;
    border-radius: 3px;
    box-shadow: 0px 0px 10px 0px rgba(136,136,136,0.3);
    margin-bottom: 20px;
}
.title {
    color: #4A9DFF;
    font-weight: 600;
    font-size: 1.1em;
}
.text {
    color: #4A4A4A;
    font-weight: 300;
}
.bg-F6F6F6 {
    background: #F6F6F6;
}
.q-expansion-item__toggle-icon {
    color: #4A9DFF;
}
</style>

<script>
export default {
  name: 'FaqElement',
  props: {
    question: {
      type: String,
      required: true
    },

    answer: {
      type: String,
      required: true
    }
  }
}
</script>
