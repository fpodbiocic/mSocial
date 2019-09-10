<template>
    <div id="home">
        <h3>Home</h3>
    </div>
</template>

<script>
    import Posts from "../components/home/Posts.vue";

    export default {
        name: 'home',
        components: {
            Posts: Posts
        },
        created: function () {

            this.getPosts();

        },
        data() {
            return {

            }
        },
        methods: {
            getPosts: function () {

                this.$store.dispatch('fetchPosts');

            }
        }
    }
</script>

<style scoped>
    
</style>