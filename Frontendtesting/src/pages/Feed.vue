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
  created () {
    if (localStorage.loggedIn !== 'true') {
      this.$router.push({ name: 'login' })
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
        if (this.Temp[i].dish === null) {
          this.Temp[i].dish = 'Unknown Dish'
        }
        if (this.Temp[i].chef === null) {
          this.Temp[i].chef = 'Unknow Chef'
        }
        this.Posts.push({
          postId: this.Temp[i].postId,
          dish: this.Temp[i].dish,
          chef: this.Temp[i].chef
        })
      }
      console.log(this.Posts)
    }
  }
}
</script>
