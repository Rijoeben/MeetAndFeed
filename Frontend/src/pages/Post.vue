<template>
  <div class="q-pa-md">
    <q-card class="my-card">
      <q-card-section>
        <div class="text-h6">{{postData.dish}}</div>
        <div class="text-subtitle2">by {{postData.chef}}</div>
      </q-card-section>

      <q-tabs v-model="tab" active-color="primary">
        <q-tab label="Participants" name="Participants" />
        <q-tab label="Previous reviews" name="Reviews" />
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
        </q-tab-panel>

        <q-tab-panel name="Reviews">
          <div v-if="this.postData.reviews.length > 0">
            <div v-for="(Review, index) in this.postData.reviews" :key="index">
              <q-card flat bordered class="my-card">
                <q-card-section>
                  <div class="text-h6">{{Review.firstname}}</div>
                </q-card-section>

                <q-card-section class="q-pt-none">
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore et dolore magna aliqua.
                </q-card-section>

                <q-separator inset />

                <q-card-section>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                  tempor incididunt ut labore et dolore magna aliqua.
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
      Reviews: []
    }
  },
  async created () {
    this.postId = this.$route.params.id
    await this.RequestData()
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
        this.postData.reviews.forEach(async function (element) {
          console.log(element)
          // const name = await this.getUserForReview(element[3])
          element.push({
            name: 'test'
          })
        })
      }
    },
    async getUserForReview (userId) {
      const { data } = await UserRepository.getUserById(userId)
      const fullname = data.firstname + ' ' + data.lastname
      return fullname
    }
  }
}
</script>
