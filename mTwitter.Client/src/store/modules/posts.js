// Mutations
import { SET_POSTS, SET_POST } from "../mutations/posts-mutations";

const state = {
    post: {},
    posts: []
};

// In Vuex, mutations are synchronous transactions:
// You cannot directly call a mutation handler. You need to call store.commit
// Since a Vuex store's state is made reactive by Vue, when we mutate the state, Vue components observing the state will update automatically. This also means Vuex mutations are subject to the same reactivity caveats when working with plain Vue
// we can use the ES2015 computed property name feature
// to use a constant as the function name
const mutations = {
    
    [SET_POSTS](state, payload) {
        state.posts = payload;
    }
};

// Instead of mutating the state, actions commit mutations.
// Actions can contain arbitrary asynchronous operations.
// Action handlers receive a CONTEXT object which exposes the same set of methods/properties on the store instance, sou you can call context.commit to commit a mutation, or access the state and getters via context.state and context.getters
// We can even call other actions with context.dispatch
// Actions are triggered with the store.dispatch method
const actions = {
    fetchPosts: function (context) {

        return new Promise((resolve, reject) => {

            fetch('/api/Posts')
                .then(response => response.json())
                .then(data => {
                    let payload = data;
                    context.commit(SET_POSTS, payload);
                    resolve();
                })
                .catch(error => reject(error));

        });

    }
};

const getters = {

};

export default {
    state,
    mutations,
    actions,
    getters
}