// Import posts mutation types
import { LOADING } from "../mutations-types/post-mutations";

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
    }
}

const actions = {}

export default {
    state: state,
    mutations: mutations,
    actions: actions
};