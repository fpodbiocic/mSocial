import Vue from "vue";
import VueRouter from "vue-router";

Vue.use(VueRouter);

// Landing view and components
import Landing from "./views/Landing.vue";

// Home view and components
import Home from "./views/Home.vue";

const router = new VueRouter({
    mode: 'history',
    routes: [
        {
            path: '/',
            name: 'landing',
            component: Landing
        },
        {
            path: '/feed',
            name: 'feed',
            components: {
                default: Home,
            }
        },
        {
            path: '/mynetwork',
            name: 'mynetwork',
            components: {}
        },
        {
            path: '/jobs',
            name: 'jobs',
            components: {}
        },
        {
            path: '/messaging',
            name: 'messaging',
            components: {}
        },
        {
            path: '/notifications',
            name: 'notifications',
            components: {}
        }
    ]
});

export default router;