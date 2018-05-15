<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white">
            <div class="container">
                <h1 class="display-4">Newsletter signup</h1>
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
                    <button type="submit" class="btn btn-primary w-100">Signup</button>
                </div>
            </div>
        </div>

    </div>
</template>

<script>
export default {
  data () {
    return {
        email: ""
    }
  },
  methods:{
      submit(){
          this.$http.post('/signup', {email: this.email}).then(data => {
              
          });
      }
  }
}
</script>

<style>
</style>
