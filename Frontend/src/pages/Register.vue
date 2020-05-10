<template>
  <div class="q-pa-md" style="max-width: 400px">
    <div class="row justify-center">
      <h5>Register</h5>
    </div>

    <q-form
      @submit="onSubmit"
      @reset="onReset"
      class="q-gutter-md"
    >
      <div class="fit row justify-between items-start content-start nameInputContainer">
        <q-input required v-model="fname" filled type="text" label="Firstname" class="nameInput" />
        <q-input required v-model="lname" filled type="text" label="Lastname" class="nameInput" />
      </div>
      <div class="fit row justify-between items-start content-start nameInputContainer">
        <q-input required v-model="street" filled type="text" label="Street and number" class="nameInput" />
        <q-input required v-model="city" filled type="text" label="City" class="nameInput" />
      </div>
      <q-input required v-model="email" filled type="email" label="Email" />
      <q-select required filled v-model="veg" :options="vegoptions" label="Vegetarian"/>
      <q-select required filled v-model="gender" :options="genoptions" label="Gender"/>
      <q-input required v-model="password" filled :type="isPwd ? 'password' : 'text'" label="Password">
        <template v-slot:append>
          <q-icon
            :name="isPwd ? 'visibility_off' : 'visibility'"
            class="cursor-pointer"
            @click="isPwd = !isPwd"
          />
        </template>
      </q-input>
      <q-input required filled v-model="date" label="Date of birth">
        <template v-slot:append>
          <q-icon name="event" class="cursor-pointer">
            <q-popup-proxy ref="qDateProxy" transition-show="scale" transition-hide="scale">
              <q-date v-model="date" mask="YYYY-MM-DD" @input="() => $refs.qDateProxy.hide()" />
            </q-popup-proxy>
          </q-icon>
        </template>
      </q-input>
      <q-toggle v-model="accept" label="I accept the license and terms" />

      <div class="fit row wrap justify-start items-end content-end">
        <q-btn label="Register" type="submit" color="primary"/>
        <q-btn label="Already have an account? Login" @click="$router.push('/')" color="primary" flat class="RegBut" />
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
.nameInput {
  max-width: 49%;
}
.nameInputContainer {
  max-width: 328px;
}
</style>
<script>
import { RepositoryFactory } from './../repositories/repositoryFactory'
const UserRepository = RepositoryFactory.get('user')

export default {
  data () {
    return {
      fname: null,
      lname: null,
      street: null,
      city: null,
      email: null,
      veg: null,
      gender: null,
      password: null,
      date: null,
      adress: null,

      accept: true,
      isPwd: true,
      vegoptions: [
        'Yes', 'No'
      ],
      genoptions: [
        'M', 'F', 'X'
      ]
    }
  },

  methods: {
    async onSubmit () {
      if (this.accept === true) {
        if (this.email !== '' && this.password !== '') {
          if (this.veg === 'Yes') {
            this.veg = true
          } else {
            this.veg = false
          }
          this.adress = this.street + ' ' + this.city

          const responsedata = await UserRepository.RegisterUser(this.fname, this.lname, this.adress, this.email, this.veg, this.password, this.gender, this.date)
          console.log(responsedata)

          if (responsedata !== null) {
            this.$router.push({ name: 'login' })
          } else {
            console.log('Registration failed')
          }
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
