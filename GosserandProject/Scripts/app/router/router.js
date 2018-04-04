import Vue from 'vue'
import Router from 'vue-router'
import Login from '../login/Login.vue'

Vue.use(Router)

const routes = [
    {
        path: '', redirect: '/'
    },
    {
        path: '/login', component: Login
    },
    {
        path: '/admin',
        component: AdminLayout
    }
]