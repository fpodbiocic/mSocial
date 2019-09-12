<template>
    <div id="posts">
        <Post />
        <Post />
    </div>
</template>

<script>
    import Post from "./Post.vue";

    export default {
        name: "Posts",
        components: {
            Post: Post
        }
    }
</script>

<style scoped>
    #posts {
        margin-top: 0.5rem;
        /*border: 1px solid black;*/
    }
</style>