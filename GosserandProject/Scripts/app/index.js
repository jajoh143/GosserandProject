import Vue from 'vue'
import router from './router/router'
import Vuetify from 'vuetify'

Vue.use(Vuetify)

const app = new Vue({
    router
}).$mount("#app")