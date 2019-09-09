import Vue from 'vue';
import App from './App.vue';

import router from "./router";
import store from "./store/store";

Vue.config.productionTip = true;

new Vue({
    router: router, // inject the rotuer into all child components (available via this.$router in all child components)
    store: store, // inject the store into all child components (available via this.$store.state in all child components)
    render: h => h(App)
}).$mount('#app');
