import Vue from "vue";
import VueRouter from "vue-router";

// Views (components)
import Landing from "./views/Landing.vue";
import Home from "./views/Home.vue";

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
            component: Home
        }
    ]
});

export default router;