<template>
  <q-layout view="lHh Lpr lFf">
    <q-header elevated>
      <q-toolbar class="full-width row wrap justify-between items-center content-center toolbar">
        <q-avatar>
          <img src="https://cdn.quasar.dev/img/avatar.png">
        </q-avatar>
        <q-toolbar-title shrink>MeetAndFeed</q-toolbar-title>
        <q-btn @click="drawerRight = !drawerRight" flat round dense icon="menu" />
      </q-toolbar>
    </q-header>
    <q-drawer
      side="right"
      v-model="drawerRight"
      show-if-above
      content-class="bg-blue"
    >
      <q-list class="full-width column wrap justify-start items-center content-center NavLinks">
        <EssentialLink
          v-for="link in essentialLinks"
          :key="link.title"
          v-bind="link"
          class="link"
        />
        <EssentialLink
          v-for="link in specialLinks"
          :key="link.title"
          v-bind="link"
          class="link special_link"
        />
      </q-list>
    </q-drawer>
    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<style scoped>
.NavLinks {
  margin-top: 40px;
}
.drawer {
  max-width: 50vw;
  width: 50vw;
}
.link {
  color: #F5F5F5;
  margin-top: 30px;
}
.special_link {
  background: white;
  color: #2489FF;
  border-radius: 3px;
  display: grid;
  align-items: center;
}
.toolbar {
  min-width: 100vw;
}
</style>

<script>
import EssentialLink from 'components/EssentialLink'

export default {
  name: 'MainLayout',
  components: {
    EssentialLink
  },
  data () {
    return {
      drawerRight: false,
      essentialLinks: [
        {
          title: 'Home',
          link: 'https://quasar.dev'
        },
        {
          title: 'Faq',
          link: 'https://github.com/quasarframework'
        },
        {
          title: 'Account',
          link: 'https://chat.quasar.dev'
        },
        {
          title: 'Contact',
          link: 'https://forum.quasar.dev'
        }
      ],
      specialLinks: [
        {
          title: 'Meet And Feed',
          link: 'https://twitter.quasar.dev'
        }
      ]
    }
  }
}
</script>
