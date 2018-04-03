<template>
  <div>
    <router-view></router-view>
  </div>
</template>
<script>
export default {
  data () {
    return {
      sideNav: {
        model: null,
        clipped: false,
        floating: false,
        mini: false
      },
      user_loggedIn: false,
      appStyle: {
        width: '100%'
      }
    }
  },
  computed: {

  }
}
</script>
