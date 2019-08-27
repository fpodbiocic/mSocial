<template>
    <div id="home">
        <h1>Home</h1>
        <loader v-bind:loading="loading" v-bind:color="loaderColor"></loader>
    </div>
</template>

<script>
    export default {
        name: 'Home',
        data() {
            return {
                loading: false,
                loaderColor: "#1da1f2",
                errors: {}
            }
        },
        created() {

            this.fetchPosts();

        },
        methods: {
            fetchPosts: function () {

                this.loading = true;
                fetch('')

            }
        }
    }
</script>

<style scoped>
</style>