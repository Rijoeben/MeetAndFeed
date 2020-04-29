<template>
  <q-layout view="lHh Lpr lFf">
    <q-header elevated class="above">
      <q-toolbar class="full-width row wrap justify-between items-center content-center toolbar">
        <q-avatar>
          <img src="https://cdn.quasar.dev/img/avatar.png">
        </q-avatar>
        <q-toolbar-title shrink>
          <img src="../assets/Logo-White.png" class="logo">
      </q-toolbar-title>
        <q-btn @click="drawerRight = !drawerRight"
         flat
         icon="menu"
         dense
         round
        />
      </q-toolbar>
    </q-header>
    <q-drawer
      side="right"
      v-model="drawerRight"
      show-if-above
      class="below"
      content-class="bg-primary"
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
  font-size: 1.2em;
  font-weight: 500;
}
.special_link {
  background: #F5F5F5;
  color: #4A9DFF;
  border-radius: 3px;
  display: grid;
  align-items: center;
}
.toolbar {
  min-width: 100vw;
}
.above {
  position: fixed;
  z-index: 100;
}
.below {
  position: relative;
  z-index: 10;
}
.logo {
  width: auto;
  height: 20px;
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
          link: '#/feed'
        },
        {
          title: 'Faq',
          link: '#/faq'
        },
        {
          title: 'Account',
          link: '#/account'
        },
        {
          title: 'Contact',
          link: '#/contact'
        }
      ],
      specialLinks: [
        {
          title: 'Meet And Feed',
          link: '#/createpost'
        }
      ]
    }
  }
}
</script>
