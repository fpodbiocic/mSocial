import Vue from 'vue';
import App from './App.vue';

import router from "./router";

Vue.config.productionTip = true;

new Vue({
    router: router, // inject the rotuer into all child components (available via this.$router in all child components)
    render: h => h(App)
}).$mount('#app');
