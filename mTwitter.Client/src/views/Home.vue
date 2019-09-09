<template>
    <div id="home">
        <Header />
        <Posts v-bind:loading="loadingPosts" v-bind:posts="posts" />
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
                
            }
        },
        created() {

            this.getPosts();

        },
        methods: {
            getPosts: function () {

                this.$store.dispatch('fetchPosts');

            }
        },
        computed: {
            ...mapState({
                loadingPosts: function (state) {
                    return state.posts.loading;
                },
                posts: function (state) {
                    return state.posts.posts;
                }
            })
        }
    };
</script>

<style scoped>
    #home {
        display: flex;
        flex-direction: column;
        border: 1px solid #e6ecf0;
    }
</style>