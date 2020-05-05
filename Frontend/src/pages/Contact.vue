<template>
    <div class="q-pa-md" style="max-width: 400px">
        <div class="row justify-center">
            <h5>Contact us</h5>
        </div>
        <q-form class="q-gutter-md">
            <q-input v-model="name" label="Name" required dense filled />
            <q-input v-model="email" label="Email" required dense filled />
            <q-input v-model="subject" label="Subject" required dense filled />
            <q-input
                v-model="message"
                filled
                dense
                color="primary"
                type="textarea"
                label="Message"
            />
            <q-btn label="Send message" type="submit" color="primary" @click="Send"/>
            <q-dialog v-model="alertSend">
                <q-card>
                    <q-card-section>
                    <div class="text-h6">Succes</div>
                    </q-card-section>

                    <q-card-section class="q-pt-none">
                    Your message has been sent. You will hear from us soon.
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
        </q-form>
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
  name: 'Contact',
  data () {
    return {
      name: '',
      email: '',
      subject: '',
      message: '',
      alertSend: false,
      cancelAlert: false
    }
  },
  created () {
    if (localStorage.loggedIn !== 'true') {
      this.$router.push({ name: 'login' })
    }
  },
  methods: {
    Cancel () {
      this.cancelAlert = true
    },
    Send () {
      if (this.name !== '' && this.email !== '' && this.subject !== '' && this.message !== '') {
        this.alertSend = true
      }
    },
    PushRouter () {
      this.$router.push({ name: 'feed' })
    }
  }
}
</script>
