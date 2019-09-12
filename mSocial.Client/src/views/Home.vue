<template>
    <div id="home">
        <a-row>
            <a-col :lg="5">
                <HomeLeftSidebar />
            </a-col>
            <a-col :lg="14" id="home-main-content">
                <CreatePost />
                <Posts />
            </a-col>
            <a-col :lg="5">
                <HomeRightSidebar />
            </a-col>
        </a-row>
    </div>
</template>

<script>
    import HomeLeftSidebar from "../components/home/HomeLeftSidebar.vue";
    import CreatePost from "../components/home/CreatePost.vue";
    import HomeRightSidebar from "../components/home/HomeRightSidebar.vue";
    import Posts from "../components/home/Posts.vue";

    export default {
        name: 'home',
        components: {
            HomeLeftSidebar: HomeLeftSidebar,
            CreatePost: CreatePost,
            HomeRightSidebar: HomeRightSidebar,
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
    #home-main-content {
        padding: 0 1.5rem;
    }
</style>