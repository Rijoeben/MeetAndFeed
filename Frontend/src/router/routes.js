
const routes = [
  {
    path: '/',
    name: 'login',
    component: () => import('pages/Login.vue')
  },
  {
    path: '/user',
    name: 'user',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: '', component: () => import('pages/Feed.vue') }
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
