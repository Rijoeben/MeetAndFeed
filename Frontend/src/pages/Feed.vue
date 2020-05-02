<template>
  <div class="q-pa-md" v-if="!isFetching">
    <div v-for="(Post, index) in this.Posts" :key="index" class="caption">
      <FeedPost
        v-bind="Post"
      />
    </div>
  </div>
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
      isFetching: true,
      Temp: [],
      Posts: []
    }
  },
  mounted () {
    this.fetchData().then(() => {
      this.isFetching = false
    })
  },
  methods: {
    async fetchData () {
      const { data } = await PostRepository.getAllPosts()
      this.Temp = data
      for (let i = 0; i < this.Temp.length; i++) {
        this.Posts.push({
          dish: this.Temp[i].dish,
          postId: this.Temp[i].postId
        })
      }
      console.log(this.Posts)
    }
  }
}
</script>
