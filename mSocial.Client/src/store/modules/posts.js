// Import posts mutation types
import { LOADING, FETCH_POSTS_ERROR, SET_POSTS } from "../mutation-types/posts-mutations";

// Import posts service
import postsService from "../../services/postsService";

const state = {
    loading: false,
    post: {},
    posts: [],
    errors: {
        fetchPosts: {}
    }
}

const mutations = {
    [LOADING](state, payload) {
        state.loading = payload;
    },
    [FETCH_POSTS_ERROR](state, payload) {
        state.errors.fetchPosts = payload;
    },
    [SET_POSTS](state, payload) {
        state.posts = payload;
    }
}

const actions = {
    fetchPosts: function (context) {

        let payload;
        context.commit(LOADING, true);

        postsService.fetchPosts()
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
}

export default {
    state: state,
    mutations: mutations,
    actions: actions
};