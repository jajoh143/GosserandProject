import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/components/Admin/Login'
import AdminView from '@/components/Admin/AdminView'
import AdminApp from '@/components/Admin/AdminApp'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/admin',
      name: 'Admin',
      component: AdminView,
      children: [
        {
          path: '/login',
          name: 'Login',
          component: Login
        },
        {
          path: '/app',
          name: 'Admin App',
          component: AdminApp
        }
      ]
    }
  ]
})
