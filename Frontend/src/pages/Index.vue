<template>
  <div class="q-pa-md">
    <q-infinite-scroll @load="onLoad" :offset="250">
      <div v-for="(Post, index) in Posts" :key="index" class="caption">
        <FeedPost
          v-bind="Post"
        />
      </div>
      <template v-slot:loading>
        <div class="row justify-center q-my-md">
          <q-spinner-dots color="primary" size="40px" />
        </div>
      </template>
    </q-infinite-scroll>
  </div>
</template>
<!--get started cd naar deze map en quasar dev-->
<style scoped>
body {
  overflow: hidden;
}
</style>
<script>
import FeedPost from 'components/FeedPost'
export default {
  name: 'Feed',
  components: {
    FeedPost
  },
  data () {
    return {
      Posts: [
        {
          DishName: 'Steak with french fries',
          Cheff: 'Mastercheff Alexander'
        },

        {
          DishName: 'Moms spaghetti',
          Cheff: 'Eminem'
        },

        {
          DishName: 'Batsoup',
          Cheff: 'COVID-19'
        },
        {
          DishName: 'Steak with french fries',
          Cheff: 'Mastercheff Alexander'
        },

        {
          DishName: 'Moms spaghetti',
          Cheff: 'Eminem'
        },

        {
          DishName: 'Batsoup',
          Cheff: 'COVID-19'
        }
      ]
    }
  },
  methods: {
    onLoad (index, done) {
      setTimeout(() => {
        if (this.Posts) {
          this.Posts.push(
            {
              DishName: 'Steak with french fries',
              Cheff: 'Mastercheff Alexander'
            },

            {
              DishName: 'Moms spaghetti',
              Cheff: 'Eminem'
            },

            {
              DishName: 'Batsoup',
              Cheff: 'COVID-19'
            },
            {
              DishName: 'Steak with french fries',
              Cheff: 'Mastercheff Alexander'
            },

            {
              DishName: 'Moms spaghetti',
              Cheff: 'Eminem'
            },

            {
              DishName: 'Batsoup',
              Cheff: 'COVID-19'
            }
          )
          done()
        }
      }, 1000)
    }
  }
}
</script>
