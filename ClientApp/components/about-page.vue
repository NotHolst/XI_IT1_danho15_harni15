<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white">
            <div class="container">
                <h1 class="display-4">About us</h1>
            </div>
        </div>

        <div class="row p-4">
            <div class="col text-center">
                <span v-html="daniel.content"></span>
            </div>
            <div class="col text-center">
                <span v-html="harald.content"></span>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                daniel: "",
                harald: ""
            }
        },
        mounted() {
            var vm = this;
            this.$http.get('/api/CmsContent').then(data => {
                vm.daniel = data.data[0];
                vm.harald = data.data[1];
            });
        },
    }
</script>

<style>
</style>