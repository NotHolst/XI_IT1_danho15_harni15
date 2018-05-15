<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white">
            <div class="container">
                <h1 class="display-4">Gallery</h1>
            </div>
        </div>

        <div class="d-flex flex-wrap p-4 justify-content-center">
            <div @click="activeImage = img" :style="{ backgroundImage: 'url(' + img + ')' }"
             v-for="img in images" alt="" class="img-thumbnail hover m-4"></div>
        </div>

        <transition name="fade">
            <div @click="activeImage = null" class="lightbox" v-if="activeImage != undefined">
                <img :src="activeImage" alt="" class="img-thumbnail">
            </div>
        </transition>

    </div>
</template>

<script>
    export default {
        data() {
            return {
                activeImage: undefined,
                images: []
            }
        },
        mounted() {
            var vm = this;
            this.$http.get('/galleryimages').then(data => {
                vm.images = data.data;
            });
        },
    }
</script>

<style>

    .img-thumbnail.hover{
        width: 128px;
        height: 128px;
    }

    .hover {
        transition: all .1s ease-in-out;
        background-position: center;
        background-size: 200%;
    }

    .hover:hover {
        transform: scale(1.1);
    }

    .lightbox {
        position: absolute;
        top: 0;
        left: 0;
        bottom: 0;
        right: 0;
        display: flex;
        justify-content: center;
        background: #0000008a;
        transition: background .33s ease-out;
    }

    .fade-enter-active,
    .fade-leave-active {
        transition: opacity .5s;
    }

    .fade-enter,
    .fade-leave-to
    /* .fade-leave-active below version 2.1.8 */

        {
        opacity: 0;
    }

    .lightbox img {
        width: 70%;
        align-self: center;
    }
</style>