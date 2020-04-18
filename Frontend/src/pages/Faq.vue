<template>
    <q-list class="full-width column wrap justify-start items-center content-center NavLinks">
        <FaqElement
          v-for="el in Elements"
          :key="el.question"
          v-bind="el"
        />
      </q-list>
</template>
<!--get started cd naar deze map en quasar dev-->
<style scoped>
</style>
<script>
import FaqElement from 'components/FaqElement'

export default {
  name: 'Faq',
  components: {
    FaqElement
  },
  data () {
    return {
      Elements: [
        {
          question: 'Is it safe to use?',
          answer: 'Sure'
        },
        {
          question: 'How do I create a post?',
          answer: 'No clue'
        },
        {
          question: 'What if the person i went to is weird?',
          answer: 'Suck it up'
        },
        {
          question: 'How do we split the bill?',
          answer: 'Use a calculator'
        }
      ]
    }
  }
}
</script>
