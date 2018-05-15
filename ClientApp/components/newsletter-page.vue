<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white">
            <div class="container">
                <h1 class="display-4">Newsletter signup</h1>
            </div>
        </div>

        <div class="container">
            <div v-if="result != undefined" class="alert alert-success" role="alert">
                You are now subscribed to our newsletter!
            </div>
        </div>

        <div class="d-flex justify-content-center">
            <div class="card">
                <div class="card-header">Newsletter signup form</div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="email">Email address</label>
                        <input v-model="email" type="email" class="form-control" id="email" aria-describedby="emailHelper" placeholder="Enter email address">
                        <small id="emailHelper" class="form-text text-muted">You will be spammed</small>
                    </div>
                    <button @click="submit" class="btn btn-primary w-100">Subscribe</button>
                </div>
            </div>
        </div>

    </div>
</template>

<script>
    export default {
        data() {
            return {
                email: "",
                result: undefined
            }
        },
        methods: {
            submit() {
                this.$http.post('/api/Subscriptions', { email: this.email }).then(data => {
                    this.result = data;
                    this.email = "";
                });
            }
        }
    }
</script>

<style>
</style>