<template>
  <div class="q-pa-md">
    <q-card class="my-card">
      <q-card-section>
        <div class="text-h6 color-primary">{{postData.dish}}</div>
        <div class="text-subtitle2 color-secundary">by {{postData.chef}}</div>
        <div class="text-subtitle2 color-secundary">{{this.date}}</div>
        <q-separator class="seperator" />
        <div class="text-subtitle2 color-secundary">{{postData.description}}</div>
      </q-card-section>

      <q-tabs v-model="tab" class="color-secundary" active-color="primary">
        <q-tab :label="'Participants (' + this.postData.participants.length + '/' + this.postData.amountOfPeople +')'" name="Participants" />
        <q-tab label="Reviews" name="Reviews" />
      </q-tabs>

      <q-separator />

      <q-tab-panels v-model="tab" animated infinite swipeable>
        <q-tab-panel name="Participants">
          <div v-if="this.postData.participants.length > 0">
            <div v-for="(Participant, index) in this.postData.participants" :key="index">
                <q-chip>
                    <q-avatar>
                    <img src="https://cdn.quasar.dev/img/avatar5.jpg">
                    </q-avatar>
                    {{Participant.firstname}}
                </q-chip>
            </div>
          </div>
          <div v-else>Be the first one to join</div>
          <q-btn v-if="this.postData.participants.length < this.postData.amountOfPeople" outline color="primary" label="Participate" class="participateButton"/>
        </q-tab-panel>

        <q-tab-panel name="Reviews">
          <div v-if="this.postData.reviews.length > 0">
            <div v-for="(Review, index) in this.postData.reviews" :key="index">
              <q-card flat bordered class="my-card">
                <q-card-section>
                  <div class="text-h6">{{Review.name}}</div>
                </q-card-section>

                <q-card-section class="q-pt-none">
                  <q-rating
                    v-model="ratingModel"
                    value="5"
                    size="2em"
                    :max="5"
                    color="primary"
                    readonly
                  />
                </q-card-section>

                <q-separator inset />

                <q-card-section>
                  {{Review.content}}
                </q-card-section>
              </q-card>
            </div>
          </div>
          <div v-else>There are no reviews yet</div>
        </q-tab-panel>
      </q-tab-panels>
    </q-card>
  </div>
</template>
<style scoped>
.participateButton {
  margin-top: 15px;
  margin-left: -2px;
}
.color-primary {
  color: #4A9DFF;
}
.color-secundary {
  color: #4A4A4A;
}
.seperator {
  margin: 7px 0px;
}
</style>
<script>
import { RepositoryFactory } from './../repositories/repositoryFactory'
const PostRepository = RepositoryFactory.get('posts')
const UserRepository = RepositoryFactory.get('user')

export default {
  data () {
    return {
      tab: 'Participants',
      postId: null,
      temp: [],
      postData: [],
      ratingModel: 0,
      date: null
    }
  },
  async created () {
    this.postId = this.$route.params.id
    await this.RequestData()
    this.date = this.postData.date.substring(0, 10)
    await this.FillReviewArray()
  },
  methods: {
    async RequestData () {
      const { data } = await PostRepository.getPost(this.postId)
      this.temp = data
      if (this.temp.chef === null) {
        this.temp.chef = 'Unknown chef'
      }
      if (this.temp.dish === null) {
        this.temp.dish = 'Unknown dish'
      }
      if (this.temp.description === null) {
        this.temp.description = 'Unknown description'
      }
      if (this.temp.chef === null) {
        this.temp.chef = 'Unknown chef'
      }
      if (this.temp.participants === null) {
        this.temp.participants = []
      }
      if (this.temp.reviews === null) {
        this.temp.reviews = []
      }
      this.postData = this.temp
      console.log(this.postData)
    },
    async FillReviewArray () {
      if (this.postData.reviews.length > 0) {
        for (let i = 0; this.postData.reviews.length > i; i++) {
          // console.log(this.postData.reviews[i])
          const name = await this.getUserForReview(Number(this.postData.reviews[i].userId))
          this.postData.reviews[i].name = name
          this.postData.reviews[i].score = 3
          console.log(this.postData.reviews[i])
        }
        // console.log(this.postData.reviews[0].content)
      }
    },
    async getUserForReview (userId) {
      const { data } = await UserRepository.getUserById(userId)
      console.log(data)
      const fullname = data.firstName + ' ' + data.lastName
      return fullname
    }
  }
}
</script>
