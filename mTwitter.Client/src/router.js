import Vue from "vue";
import VueRouter from "vue-router";

// Views (components)

import Home from "./views/Home.vue";
import HomeSidebar from "./components/home/HomeSidebar.vue";

import Explore from "./views/Explore.vue";
import ExploreSidebar from "./components/explore/ExploreSidebar.vue";

import Tweet from "./views/Tweet.vue";

// enables router injection into all child components
Vue.use(VueRouter);

const router = new VueRouter({
    mode: 'history',
    routes: [
        {
            path: '/home',
            name: 'home',
            components: {
                default: Home,
                sidebar: HomeSidebar
            }
        },
        {
            path: '/explore',
            name: 'explore',
            components: {
                default: Explore,
                sidebar: ExploreSidebar
            }
        },
        {
            path: '/handle/tweet/:id',
            name: 'tweet',
            components: {
                default: Tweet
            },
            props: true
        }
    ]
});

export default router;