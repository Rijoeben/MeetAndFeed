<template>
  <div class="q-pa-md" style="max-width: 400px">
    <div class="row justify-center">
      <h5>Login</h5>
    </div>

    <q-form
      @submit="onSubmit"
      @reset="onReset"
      class="q-gutter-md"
    >
      <q-input v-model="email" filled type="email" label="Email" />

      <q-input v-model="password" filled :type="isPwd ? 'password' : 'text'" label="Password">
        <template v-slot:append>
          <q-icon
            :name="isPwd ? 'visibility_off' : 'visibility'"
            class="cursor-pointer"
            @click="isPwd = !isPwd"
          />
        </template>
      </q-input>

      <q-toggle v-model="accept" label="I accept the license and terms" />

      <div>
        <q-btn label="Login" type="submit" color="primary"/>
        <q-btn label="Forgot password?" color="primary" flat class="RegBut"/>
      </div>
      <div>
        <q-btn label="Don't have an account? Register" @click="$router.push('register')" color="primary" flat class="RegBut" />
      </div>
    </q-form>

  </div>
</template>
<style scoped>
.RegBut {
    padding: 0px;
    font-size: 0.8em;
}
h5 {
    color: #4A9DFF;
    margin: 0 0 20px 0;
}
</style>
<script>
export default {
  data () {
    return {
      email: null,
      password: null,

      accept: true,
      isPwd: true
    }
  },

  methods: {
    onSubmit () {
      if (this.accept === true) {
        if (this.email !== '' && this.password !== '') {
          if (this.email === 'test@fuck.com' && this.password === 'test') {
            console.log('succes')
            this.$emit('authenticated', true)
            this.$router.push({ name: 'feed' })
          } else {
            console.log('The username and / or password is incorrect')
          }
        } else {
          console.log('A username and password must be present')
        }
      }
    },
    onReset () {
      this.name = null
      this.age = null
      this.accept = false
      this.isPwd = true
    }
  }
}
</script>
