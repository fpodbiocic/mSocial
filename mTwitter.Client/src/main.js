import Vue from 'vue';
import App from './App.vue';
import VueMoment from "vue-moment";

import router from "./router";
import store from "./store/index";

Vue.config.productionTip = true;
Vue.use(VueMoment);

// Global components
import ClipLoader from "vue-spinner/src/ClipLoader.vue";
Vue.component('Loader', ClipLoader);

new Vue({
    // inject the router into all child components (available via this.$router in all child components)
    router: router,
    // inject the store into all child components (available via this.$store.state in all child components)
    store: store,
    render: h => h(App)
}).$mount('#app');
