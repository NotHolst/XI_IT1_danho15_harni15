<template>
    <div id="app">
        <div class="bg-dark text-white row p-4 d-flex align-items-center justify-content-between">
            <div class="">
                <h1 class="pl-3">
                    IT Assigment
                </h1>
            </div>
            <div class="">
                <nav-menu params="route: route"></nav-menu>
            </div>
        </div>
        <div class="row">
            <router-view></router-view>
        </div>
    </div>
</template>

<script>
    import NavMenu from './nav-menu'

    export default {
        components: {
            'nav-menu': NavMenu
        },

        data() {
            return {}
        }
    }
</script>

<style>
</style>