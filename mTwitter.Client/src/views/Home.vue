<template>
    <div id="home">

    </div>
</template>

<script>
    import Header from "../components/home/Header.vue";
    import Posts from "../components/home/Posts.vue";

    export default {
        name: 'home',
        components: {
            Header: Header,
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