import Vue from "vue";
import VueRouter from "vue-router";

// Views (components)
import Landing from "./views/Landing.vue";

import Home from "./views/Home.vue";
import HomeSidebar from "./components/home/HomeSidebar.vue";

import Explore from "./views/Explore.vue";
import ExploreSidebar from "./components/explore/ExploreSidebar.vue";

// enables router injection into all child components
Vue.use(VueRouter);

const router = new VueRouter({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: 'landing',
            component: Landing
        },
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
        }
    ]
});

export default router;