import Vue from 'vue'
import Router from 'vue-router'
import Login from '../login/Login.vue'

Vue.use(Router)

export default new Router({
    routes: [
        {
            path: '', redirect: '/'
        },
        {
            path: '/', component: Layout,
            children: [
                {
                    path: "login", component: Login
                },
               
            ]
        }
    ]
})