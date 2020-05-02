<template>
    <div class="q-pa-md" style="max-width: 400px">
        <div class="row justify-center">
            <h5>Create Post</h5>
        </div>
        <q-form class="q-gutter-md">
      <q-input filled dense v-model="name" label="Name of the dish" />
      <h6>
        Allergies
      </h6>
      <div class="full-width row wrap justify-evenly items-start content-start allergies-checkbox-container">
          <q-checkbox v-model="milk" label="Milk" />
          <q-checkbox v-model="eggs" label="Eggs" />
          <q-checkbox v-model="nuts" label="Nuts" />
          <q-checkbox v-model="crustaceans" label="Crustaceans" />
          <q-checkbox v-model="fish" label="Fish" />
      </div>
      <q-input filled v-model="date" mask="date" :rules="['date']">
        <template v-slot:append>
          <q-icon name="event" class="cursor-pointer">
            <q-popup-proxy ref="qDateProxy" transition-show="scale" transition-hide="scale">
              <q-date v-model="date" @input="() => $refs.qDateProxy.hide()" />
            </q-popup-proxy>
          </q-icon>
        </template>
      </q-input>
      <q-input
        v-model="text"
        filled
        dense
        type="textarea"
        label="Description"
      />
      <div>
        <q-btn label="Create post" type="submit" color="primary" @click="Post"/>
        <q-dialog v-model="createAlert">
          <q-card>
            <q-card-section>
              <div class="text-h6">Succes</div>
            </q-card-section>

            <q-card-section class="q-pt-none">
              Your post has been created
            </q-card-section>

            <q-card-actions align="right">
              <q-btn flat label="OK" color="primary" v-close-popup @click="PushRouter"/>
            </q-card-actions>
          </q-card>
        </q-dialog>

        <q-btn label="Cancel" type="cancel" color="primary" @click="Cancel" flat class="q-ml-sm" />

        <q-dialog v-model="cancelAlert">
          <q-card>
            <q-card-section>
              <div class="text-h6">Succes</div>
            </q-card-section>

            <q-card-section class="q-pt-none">
              Are you sure you want to cancel?
            </q-card-section>

            <q-card-actions align="right">
              <q-btn label="YES" color="primary" v-close-popup @click="PushRouter"/>
              <q-btn flat label="NO" color="primary" v-close-popup/>
            </q-card-actions>
          </q-card>
        </q-dialog>
      </div>
    </q-form>
    </div>
</template>

<style scoped>
h5 {
    color: #4A9DFF;
    margin: 0 0 20px 0;
}
h6 {
    color: #4A9DFF;
    font-size: 1.2em;
    margin-bottom: 0;
}
.allergies-checkbox-container {
    margin-top: 0;
}
.text-h6 {
  color: #4A9DFF;
}
</style>

<script>
import { RepositoryFactory } from './../repositories/repositoryFactory'
const PostRepository = RepositoryFactory.get('posts')

export default {
  name: 'CreatePost',
  data () {
    return {
      name: '',
      text: '',
      milk: false,
      eggs: false,
      nuts: false,
      crustaceans: false,
      fish: false,
      createAlert: false,
      cancelAlert: false,
      date: null
    }
  },
  methods: {
    Cancel () {
      this.cancelAlert = true
    },
    Post () {
      if (this.name !== '' && this.text !== '') {
        this.createAlert = true
        const res = PostRepository.createPost(this.dish, this.description, this.date)
        console.log(res.data)
      }
    },
    PushRouter () {
      this.$router.push({ name: 'feed' })
    }
  }
}
</script>
