<template>
  <q-page class="q-pa-md" style="min-width: 100vw">
    <q-card class="my-card">
      <q-card-section>
        <div class="GoBack" @click="$router.push({ name: 'feed' })"><q-icon name="keyboard_backspace" class="backIcon" />Go back</div>
        <div class="text-h4 color-primary">{{postData.dish}}</div>
        <div class="text-subtitle1 color-secundary">by {{postData.chef}}</div>
        <div class="text-subtitle2 color-secundary">{{this.date}}</div>
        <q-separator class="seperator" />
        <div class="text-h6 color-secundary">{{postData.description}}</div>
      </q-card-section>

      <q-tabs v-model="tab" class="color-secundary" active-color="primary">
        <q-tab :label="'Participants (' + this.postData.participants.length + '/' + this.postData.amountOfPeople +')'" name="Participants" />
        <q-tab label="Reviews" name="Reviews" />
      </q-tabs>

      <q-separator />

      <q-tab-panels v-model="tab" animated infinite swipeable>
        <q-tab-panel name="Participants">
          <div v-if="this.postData.participants.length > 0">
            <div v-for="(Participant, index) in this.postData.participants" :key="index" class="margin-bottom">
                <q-chip class="color-primary" size="md">
                    <q-avatar>
                    <img src="https://cdn.quasar.dev/img/avatar5.jpg">
                    </q-avatar>
                    {{Participant.firstName}} {{Participant.lastName}}
                </q-chip>
            </div>
          </div>
          <div v-else>Be the first one to join</div>
          <q-btn v-if="this.postData.participants.length < this.postData.amountOfPeople" outline color="primary" label="Participate" class="participateButton" @click="AddParticipant" />
        </q-tab-panel>

        <q-tab-panel name="Reviews">
          <div v-if="this.postData.reviews.length > 0">
            <div v-for="(Review, index) in this.postData.reviews" :key="index">
              <q-card flat bordered class="my-card rating">
                <q-card-section>
                  <div class="text-h6 color-primary">{{Review.name}}</div>
                </q-card-section>

                <q-card-section class="q-pt-none">
                  <q-rating
                    :value="Review.score"
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
          <q-btn outline color="primary" label="Create review" class="participateButton" @click="tempAddReview" />

          <q-dialog v-model="prompt" persistent>
            <q-card style="min-width: 350px">
              <q-card-section>
                <div class="text-h6 color-primary">Create review</div>
              </q-card-section>
              <q-card-section class="q-pt-none">
                <q-rating
                  v-model="createReviewScore"
                  size="2em"
                  :max="5"
                  color="primary"
                />
                <q-input filled type="textarea" v-model="createReviewContent" label="Write your review" style="margin-top: 15px" />
              </q-card-section>

              <q-card-actions align="right" class="text-primary">
                <q-btn flat label="Cancel" v-close-popup />
                <q-btn flat label="Post review" v-close-popup @click="AddReview" />
              </q-card-actions>
            </q-card>
          </q-dialog>

        </q-tab-panel>
      </q-tab-panels>
    </q-card>
  </q-page>
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
.margin-bottom {
  margin-bottom: 5px;
}
.backIcon {
  font-size: 20px;
  margin-right: 5px;
}
.GoBack {
  font-size: 14px;
  color: #4A9DFF;
  cursor: pointer;
  display: flex;
  align-items: center;
  margin-bottom: 10px;
}
.rating {
  margin-bottom: 15px;
}
</style>
<script>
import { RepositoryFactory } from './../repositories/repositoryFactory'
const PostRepository = RepositoryFactory.get('posts')
const UserRepository = RepositoryFactory.get('user')
const ParticipantRepository = RepositoryFactory.get('participant')
const ReviewRepository = RepositoryFactory.get('review')

export default {
  data () {
    return {
      tab: 'Participants',
      postId: null,
      temp: [],
      postData: [],
      date: null,

      prompt: false,
      createReviewContent: null,
      createReviewScore: 0
    }
  },
  async created () {
    this.postId = this.$route.params.id
    await this.RequestData()
    this.date = this.postData.date.substring(0, 10)
    await this.FillReviewArray()
    console.log(this.$data)
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
          console.log(this.postData.reviews[i])
        }
        // console.log(this.postData.reviews[0].content)
      }
    },
    async AddParticipant () {
      const { data } = await ParticipantRepository.UpdateParticipant(Number(localStorage.userId), Number(this.postId))
      console.log(data)
      location.reload()
    },
    async getUserForReview (userId) {
      const { data } = await UserRepository.getUserById(userId)
      console.log(data)
      const fullname = data.firstName + ' ' + data.lastName
      return fullname
    },
    async AddReview () {
      const respdata = await ReviewRepository.CreateReview(this.createReviewContent, this.createReviewScore, Number(localStorage.userId))
      console.log(respdata.data)
      const otherrespdata = await PostRepository.AppendReview(Number(respdata.data.reviewId), this.postId)
      console.log(otherrespdata)
      location.reload()
    },
    tempAddReview () {
      this.prompt = true
    }
  }
}
</script>
