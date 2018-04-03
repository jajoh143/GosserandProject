<template>
  <div>
    <v-navigation-drawer v-model="sideNav.model"
                         :clipped="sideNav.clipped"
                         :floating="sideNav.floating"
                         absolute
                         overflow
                         app>
      <v-toolbar flat>
      </v-toolbar>
    </v-navigation-drawer>
    <v-toolbar app
               absolute
               :clipped-left="sideNav.clipped"
               dark
               color="blue">
      <v-toolbar-side-icon @click="sideNav.model = !sideNav.model"
                           v-if="sideNav.type !== 'permanent'"
                           dark
                           color="blue darken-2"></v-toolbar-side-icon>
      <v-spacer></v-spacer>
      <v-menu>
        <v-toolbar-title slot="activator">
          User Menu Here
        </v-toolbar-title>
        <v-list>
          <v-list-tile>
            <v-icon>perm_identity</v-icon>&nbsp;Logout
          </v-list-tile>
        </v-list>
      </v-menu>
    </v-toolbar>
    <v-content>
      <v-container fluid>
        <v-layout align-center justify-center>
          <div id="app_container" v-bind:style="appStyle">
            <router-view></router-view>
          </div>
        </v-layout>
      </v-container>
    </v-content>
  </div>
</template>
<script>
export default {

}
</script>
