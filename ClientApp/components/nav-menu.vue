<template>
    <div class="main-nav">
        <nav class="nav nav-tabs|pills nav-stacked">
            <router-link :to="route.path" v-for="(route, index) in routes" :key="index"
            class="nav-link active text-white" href="#">{{route.display}}</router-link>
        </nav>
    </div>
</template>

<li class="nav-item" v-for="(route, index) in routes" :key="index">
    <router-link :to="route.path" exact-active-class="active">
        <icon :icon="route.icon" class="mr-2" /><span>{{ route.display }}</span> 
    </router-link>
</li>

<script>
    import { routes } from '../router/routes'

    export default {
      data () {
        return {
          routes,
          collapsed: true
        }
      },
      methods: {
        toggleCollapsed: function (event) {
          this.collapsed = !this.collapsed
        }
      }
    }
</script>

<style scoped>

</style>