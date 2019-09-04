<template>
    <div id="home">
        <Header />
        <Posts />
        <!--<loader v-bind:loading="loading" v-bind:color="loaderColor" v-bind:size="loaderSize"></loader>-->
    </div>
</template>

<script>
    import { mapState } from "vuex";

    // components
    import Header from "../components/home/Header.vue";
    import Posts from "../components/home/Posts.vue";

    export default {
        name: 'Home',
        components: {
            Header: Header,
            Posts: Posts
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
    };
</script>

<style scoped>
    #home{
       display: flex;
       flex-direction: column;
       /*border: 1px solid black;*/
    }
</style>