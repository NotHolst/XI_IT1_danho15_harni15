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
                        <div class="col text-center" contenteditable="true">
                            <h2>Daniel Holst</h2>
                            <br/>
                            <p>
                                <b>Age</b>:
                                <br/>22
                            </p>
                            <p>
                                <b>Height</b>:
                                <br/>178cm
                            </p>
                            <p>
                                <b>Field of study</b>:
                                <br/>Software Engineering
                            </p>
                            <p>
                                <b>Favourite dish</b>:
                                <br/>Pretty much everything Italian
                            </p>
                            <p>
                                <b>Favourite game</b>:
                                <br/>Overwatch
                            </p>
                            <p>
                                <b>Favourite programming language</b>:
                                <br/>Emoji
                            </p>
                        </div>
                        <div class="col text-center" contenteditable="true">
                            <h2>Harald Dyg</h2>
                            <br/>
                            <p>
                                <b>Age</b>:
                                <br/>21
                            </p>
                            <p>
                                <b>Height</b>:
                                <br/>187cm
                            </p>
                            <p>
                                <b>Field of study</b>:
                                <br/>Software Engineering
                            </p>
                            <p>
                                <b>Favourite dish</b>:
                                <br/>"Bangers n' mash"
                            </p>
                            <p>
                                <b>Favourite game</b>:
                                <br/>Also Overwatch
                            </p>
                            <p>
                                <b>Favourite programming language</b>:
                                <br/>HTML
                            </p>
                        </div>
                    </div>
                    <a @click="resetChanges" class="btn btn-secondary w-100" href="#" role="button">Reset changes</a>
                    <a @click="saveChanges" class="btn btn-primary w-100" href="#" role="button">Save changes</a>
                </div>
                <div class="tab-pane fade" id="uploadimage" role="tabpanel">
                    <div class="d-flex justify-content-center p-4">
                        <div class="form-group">
                            <label for="image">Choose image to upload</label>
                            <input type="file" class="form-control-file" name="image" id="image" placeholder="" aria-describedby="fileHelpId">
                        </div>
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
                daniel: "",
                harald: ""
            }
        },
        mounted() {
            var vm = this;
            this.$http.get('/aboutcontent').then(data => {
                vm.daniel = data.data[0];
                vm.harald = data.data[1];
            });
        },
    };
</script>

<style>
</style>