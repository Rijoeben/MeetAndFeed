
const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: '', name: 'login', component: () => import('pages/Login.vue') },
      { path: '/register', name: 'register', component: () => import('pages/Register.vue') },
      { path: '/feed', name: 'feed', component: () => import('pages/Feed.vue') },
      { path: '/faq', name: 'faq', component: () => import('pages/Faq.vue') },
      { path: '/account', name: 'account', component: () => import('pages/Account.vue') },
      { path: '/contact', name: 'contact', component: () => import('pages/Contact.vue') },
      { path: '/createpost', name: 'createpost', component: () => import('pages/CreatePost.vue') }
    ]
  }
]

// Always leave this as last one
if (process.env.MODE !== 'ssr') {
  routes.push({
    path: '*',
    component: () => import('pages/Error404.vue')
  })
}

export default routes
