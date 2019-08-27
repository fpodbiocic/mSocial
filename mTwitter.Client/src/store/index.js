import Vue from "vue";
import Vuex from "vuex";

// Modules
import auth from "./modules/auth";
import posts from "./modules/posts";

// enables store injection into all child components
// The only way to actually change state in a Vuex store is by committing a mutation. Vuex mutations are very similar to events: each mutation has a string type and a handler. The handler function is where we perform actual state modifications, and it will receive the state as the first argument
Vue.use(Vuex);

const store = new Vuex.Store({

    modules: {
        auth: auth,
        posts: posts
    }

});

export default store;