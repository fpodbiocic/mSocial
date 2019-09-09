<template>
    <div id="posts">
        <loader v-bind:loading="loading" v-bind:color="loaderColor" v-bind:size="loaderSize" class="my-3"></loader>
        <Post v-for="post in posts" v-bind:key="post.id" v-bind:post="post" />
    </div>
</template>

<script>
    import Post from "./Post.vue";

    export default {
        name: "Posts",
        props: {
            loading: {
                type: Boolean,
                required: true
            },
            posts: {
                type: Array,
                required: true
            }
        },
        components: {
            Post: Post
        },
        data() {
            return {
                loaderColor: "#1da1f2",
                loaderSize: "50px"
            }
        }
    };
</script>

<style scoped>
    #posts {
        
    }
</style>