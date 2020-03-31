<template>
  <q-item
    clickable
    tag="a"
    target="_blank"
    :href="link"
  >
    <q-item-section class="link-container">
      <q-item-label class="Link">{{ title }}</q-item-label>
    </q-item-section>
  </q-item>
</template>

<style scoped>
.Link {
  font-size: 1.4em;
  padding: 0 0 2px 0;
  margin: 0;
  display: flex;
  align-items: center;
}
</style>

<script>
export default {
  name: 'EssentialLink',
  props: {
    title: {
      type: String,
      required: true
    },
    link: {
      type: String,
      default: '#'
    }
  }
}
</script>
