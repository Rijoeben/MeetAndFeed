<template>
  <q-infinite-scroll @load="onLoad" :offset="250">
    <div v-for="(Post, index) in Posts" :key="index" class="caption full-width column wrap justify-start items-center content-center">
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
</template>
<!--get started cd naar deze map en quasar dev-->
<style scoped>
</style>
<script>
import FeedPost from 'components/FeedPost'
import { RepositoryFactory } from './../repositories/repositoryFactory'
const PostRepository = RepositoryFactory.get('posts')

export default {
  name: 'Feed',
  components: {
    FeedPost
  },
  data () {
    return {
      Posts: []
    }
  },
  created () {
    this.fetch()
  },
  methods: {
    async fetch () {
      const { data } = await PostRepository.getAllPosts()
      this.Posts = data
      console.log(data)
    },
    onLoad (index, done) {
      setTimeout(() => {
        if (this.Posts) {
          this.Posts.push()
          done()
        }
      }, 1000)
      console.log('loaded')
    }
  }
}
</script>
