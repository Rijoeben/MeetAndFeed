<template>
  <div class="q-pa-md" style="max-width: 400px">
    <div class="full-width column wrap justify-start items-center content-center">
      <h5>Account</h5>
      <q-form class="q-gutter-md full-width column wrap justify-start items-center content-center">
        <q-btn flat color="primary" label="Change password" @click="RequestPassword" />
        <div class="full-width row justify-evenly items-center">
          <q-avatar>
            <img src="https://cdn.quasar.dev/img/avatar.png">
          </q-avatar>
          <q-file
            v-model="file"
            label="Change profile picture"
            flat
            borderless
            label-color="primary"
            clearable
            accept=".jpg, image/*"
            style="width: 50%; mex-height: 30px;"
          />
        </div>

        <q-btn color="primary" label="Save Changes" @click="SaveChanges" />
      </q-form>
    </div>
  </div>
</template>
<style scoped>
h5 {
    color: #4A9DFF;
    margin: 0 0 20px 0;
}
</style>

<script>
export default {
  name: 'Account',
  data () {
    return {
      file: null
    }
  },
  created () {
    if (!localStorage.loggedIn) {
      this.$router.push({ name: 'login' })
    }
  },
  methods: {
    RequestPassword () {
      return null
    },
    SaveChanges () {
      this.$router.push({ name: 'feed' })
    }
  }
}
</script>
