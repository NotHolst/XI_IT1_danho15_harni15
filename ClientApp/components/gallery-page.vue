<template>
    <div class="w-100">
        <div class="jumbotron jumbotron-fluid bg-primary text-white">
            <div class="container">
                <h1 class="display-4">Gallery</h1>
            </div>
        </div>

        <div class="d-flex flex-wrap p-4 justify-content-center">
            <img @click="activeImage = img" v-for="img in images" :src="img.thumbnail" alt="" class="img-thumbnail m-4">
        </div>

        <transition name="fade">
            <div @click="activeImage = null" class="lightbox" v-if="activeImage != undefined">
                <img :src="activeImage.image" alt="">
            </div>
        </transition>

    </div>
</template>

<script>
    export default {
        data() {
            return {
                activeImage: undefined,
                images: [
                    {
                        thumbnail: 'http://via.placeholder.com/128x128?text=1',
                        image: 'http://via.placeholder.com/1280x720?text=Full image'
                    },
                    {
                        thumbnail: 'http://via.placeholder.com/128x128?text=2',
                        image: 'http://via.placeholder.com/1280x720?text=Full image'
                    },
                    {
                        thumbnail: 'http://via.placeholder.com/128x128?text=3',
                        image: 'http://via.placeholder.com/1280x720?text=Full image'
                    },
                    {
                        thumbnail: 'http://via.placeholder.com/128x128?text=4',
                        image: 'http://via.placeholder.com/1280x720?text=Full image'
                    },

                ]
            }
        },
        mounted() {

        },
        watch: {
            activeImage() {

            }
        }
    }
</script>

<style>
    .img-thumbnail {
        transition: all .1s ease-in-out;
    }

    .img-thumbnail:hover {
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