<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white mb-0">
            <div class="container">
                <h1 class="display-4">Admin page</h1>
            </div>
        </div>
        <div class="container">
            <ul class="nav nav-pills" id="myTab" role="tablist">
                <li class="nav-item">
                    <a class="nav-link active" data-toggle="tab" href="#aboutcontent" role="tab" aria-controls="home" aria-selected="true">About page content</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" data-toggle="tab" href="#uploadimage" role="tab" aria-controls="profile" aria-selected="false">Upload image to gallery</a>
                </li>
            </ul>

            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="aboutcontent" role="tabpanel">
                    <div class="row p-4">
                        <div class="form-group col-6">
                            <label for="exampleFormControlTextarea1">About Daniel</label>
                            <textarea class="form-control" rows="10" v-model="about_daniel"></textarea>
                        </div>
                        <div class="form-group col-6">
                            <label for="exampleFormControlTextarea1">About Harald</label>
                            <textarea class="form-control" rows="10" v-model="about_harald"></textarea>
                        </div>
                    </div>
                    <a @click="resetChanges" class="btn btn-secondary w-100" href="#" role="button">Reset changes</a>
                    <a @click="saveChanges" class="btn btn-primary w-100" href="#" role="button">Save changes</a>
                </div>
                <div class="tab-pane fade" id="uploadimage" role="tabpanel">
                    <div class="d-flex justify-content-center p-4">
                        <form action="/api/Gallery" method="post" enctype="multipart/form-data">
                            <div class="form-group">
                                <label for="imageFile">Choose image to upload</label>
                                <input type="file" class="form-control-file" name="imageFile" id="imageFile" placeholder="" aria-describedby="fileHelpId">
                            </div>
                            <button type="submit" class="btn btn-primary">Upload</button>
                        </form>
                    </div>
                </div>
            </div>

        </div>


    </div>
</template>

<script>
    export default {
        data() {
            return {
                about_daniel: "",
                about_harald: ""
            };
        },
        mounted() {
            this.load();
        },
        methods: {
            load() {
                var vm = this;
                this.$http.get("/api/CmsContent").then(data => {
                    vm.about_daniel = data.data[0].content;
                    vm.about_harald = data.data[1].content;
                });
            },
            saveChanges() {
                this.$http.put('/api/CmsContent/about_daniel', {
                    id: "about_daniel",
                    content: this.about_daniel
                });
                this.$http.put('/api/CmsContent/about_harald', {
                    id: "about_harald",
                    content: this.about_harald
                });
            },
            resetChanges() {
                this.load();
            }
        }
    };
</script>

<style>
</style>