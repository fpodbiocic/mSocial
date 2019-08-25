import Vue from "vue";
import VueRouter from "vue-router";

// Views (components)
import Landing from "./views/Landing.vue";

Vue.use(VueRouter);

const router = new VueRouter({
    routes: [
        {
            path: '/',
            name: 'landing',
            component: Landing
        }
    ]
});

export default router;