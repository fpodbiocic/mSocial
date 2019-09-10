import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

// Modules
import posts from "./modules/posts";

const store = new Vuex.Store({
    modules: {
        posts: posts
    }
});

export default store;