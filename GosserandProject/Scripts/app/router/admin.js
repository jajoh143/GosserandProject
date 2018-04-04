import AdminView from '../admin/layout/AdminView.vue'

export default [
    {
        path: '/admin',
        name: 'Admin View',
        component: AdminView,
        beforeEnter: (to, from, next) => {
            // this is where I need to check and see if the user is logged in. 

        },
        children: [

        ]
    }
]