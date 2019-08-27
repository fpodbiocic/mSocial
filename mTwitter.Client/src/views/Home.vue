<template>
    <div id="home">
        <div class="container">
            <Navigation/>
            <loader v-bind:loading="loading" v-bind:color="loaderColor" v-bind:size="loaderSize"></loader>
        </div>
    </div>
</template>

<script>
    import { mapState } from "vuex";

    // components
    import Post from "../components/home/Navigation.vue";
    import Navigation from "../components/home/Navigation.vue";

    export default {
        name: 'Home',
        components: {
            Post: Post,
            Navigation: Navigation
        },
        data() {
            return {
                loading: false,
                loaderColor: "#1da1f2",
                loaderSize: "50px",
                errors: {
                    getPosts: {}
                }
            }
        },
        created() {

            this.getPosts();

        },
        methods: {
            getPosts: function () {

                this.loading = true;
                this.$store.dispatch('fetchPosts')
                    .then(() => this.loading = false)
                    .catch(error => {
                        this.errors.getPosts = error;
                        this.loading = false;
                    });

            }
        },
        computed: {
            ...mapState({
                posts: function (state) {
                    return state.posts.posts;
                }
            })
        }
    }
</script>

<style scoped>
    #home{
        
    }
</style>