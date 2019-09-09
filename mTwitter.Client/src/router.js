﻿import Vue from "vue";
import VueRouter from "vue-router";

Vue.use(VueRouter);

// Navigation
import Navigation from "./components/global/Navigation.vue";

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
            path: '/home',
            name: 'home',
            components: {
                default: Home,
                navigation: Navigation,
            }
        }
    ]
});

export default router;