// Mutations
import { LOADING, FETCH_POSTS_ERROR, SET_POSTS } from "../mutations/posts-mutations";

const state = {
    loading: false,
    post: {},
    posts: [],
    errors: {
        fetchError: null
    }
};

// In Vuex, mutations are synchronous transactions:
// You cannot directly call a mutation handler. You need to call store.commit
// Since a Vuex store's state is made reactive by Vue, when we mutate the state, Vue components observing the state will update automatically. This also means Vuex mutations are subject to the same reactivity caveats when working with plain Vue
// we can use the ES2015 computed property name feature
// to use a constant as the function name
const mutations = {

    [LOADING](state, payload) {
        state.loading = payload;
    },
    
    [SET_POSTS](state, payload) {
        state.posts = payload;
    },

    [FETCH_POSTS_ERROR](state, payload) {
        state.errors.fetchError = payload;
    }
};

// Instead of mutating the state, actions commit mutations.
// Actions can contain arbitrary asynchronous operations.
// Action handlers receive a CONTEXT object which exposes the same set of methods/properties on the store instance, sou you can call context.commit to commit a mutation, or access the state and getters via context.state and context.getters
// We can even call other actions with context.dispatch
// Actions are triggered with the store.dispatch method
const actions = {
    fetchPosts: function (context) {

        let payload;
        context.commit(LOADING, true);

        fetch('/api/Posts')
            .then(response => response.json())
            .then(data => {
                payload = data;
                context.commit(SET_POSTS, payload);
                context.commit(LOADING, false);
            })
            .catch(error => {
                payload = error;
                context.commit(FETCH_POSTS_ERROR, payload);
                context.commit(LOADING, false);
            });
    }
};

export default {
    state,
    mutations,
    actions
}