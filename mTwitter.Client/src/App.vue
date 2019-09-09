<template>
    <div id="app">
        <div class="container app-content">
            <Navigation v-if="isAuthenticated" />
            <router-view />
            <router-view name="sidebar" v-if="isAuthenticated" />
        </div>
    </div>
</template>

<script>
    import { mapState } from "vuex";

    import Navigation from "./components/Navigation.vue";

    export default {
        name: 'App',
        components: {
            Navigation: Navigation
        },
        data() {
            return {}
        },
        computed: {
            ...mapState({
                isAuthenticated: function (state) {
                    return state.auth.isAuthenticated;
                }
            })
        }
    };
</script>

<style>
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    /*  */
    :root {
        --max-width: 1280px;
        --primary-color: #1da1f2;
        --light-color: #fff;
        --dark-color: #000;
        --retweet-color: #1ad087;
        --like-color: #ff3855;
        --btn-secondary-hover: rgba(29, 161, 242, 0.1);
        --btn-primary-hover: #1b95e0;
        --retweet-hover-color: rgba(26, 208, 135, 0.1);
        --like-hover-color: rgba(255, 56, 85, 0.1);
    }
    /*----------------------------*/

    body {
        font-family: 'Source Sans Pro', sans-serif;
    }

    .container {
        max-width: var(--max-width);
        margin: 0 auto;
        overflow: hidden;
        padding: 0.8rem 1rem;
    }

    /* TEXT STYLES  */
    .text-light {
        color: var(--light-color);
    }

    .text-dark {
        color: var(--dark-color);
    }

    .text-primary {
        color: var(--primary-color);
    }

    .text-center {
        text-align: center;
    }
    /*-----------------------------*/

    /* PADDING MARGIN */
    .p-1 { padding: 1rem; }
    .p-2 { padding: 2rem; }
    .p-3 { padding: 3rem; }
    .p-4 { padding: 4rem; }
    .p-5 { padding: 5rem; }
    .p-6 { padding: 6rem; }

    .py-1 { padding: 1rem 0; }
    .py-2 { padding: 2rem 0; }
    .py-3 { padding: 3rem 0; }
    .py-4 { padding: 4rem 0; }
    .py-5 { padding: 5rem 0; }
    .py-6 { padding: 6rem 0; }

    .px-1 { padding: 0 1rem; }
    .px-2 { padding: 0 2rem; }
    .px-3 { padding: 0 3rem; }
    .px-4 { padding: 0 4rem; }
    .px-5 { padding: 0 5rem; }
    .px-6 { padding: 0 6rem; }
    .px-7 { padding: 0 7rem; }
    .px-8 { padding: 0 8rem; }

    .m-1 { margin: 1rem; }
    .m-2 { margin: 2rem; }
    .m-3 { margin: 3rem; }
    .m-4 { margin: 4rem; }
    .m-5 { margin: 5rem; }
    .m-6 { margin: 6rem; }

    .my-1 { margin: 1rem 0; }
    .my-2 { margin: 2rem 0; }
    .my-3 { margin: 3rem 0; }
    .my-4 { margin: 4rem 0; }
    .my-5 { margin: 5rem 0; }
    .my-6 { margin: 6rem 0; }

    .mx-05 { margin: 0 .5rem; }
    .mx-1 { margin: 0 1rem; }
    .mx-2 { margin: 0 2rem; }
    .mx-3 { margin: 0 3rem; }
    .mx-4 { margin: 0 4rem; }
    .mx-5 { margin: 0 5rem; }
    .mx-6 { margin: 0 6rem; }
    /*-----------------------------*/

    /* INPUT STYLES */
    input {
        border: 1px solid #e6ecf0;
        border-radius: 5px;
        padding: .8rem 1.7rem;
        margin: 0 .5rem;
    }
    /*-------------------------------*/

    /* BUTTONS */
    .btn {
        cursor: pointer;
        border: none;
        text-decoration: none;
    }

    .btn-secondary-sm {
        background: var(--light-color);
        border: 1px solid var(--primary-color);
        color: var(--primary-color);
        padding: .8rem 1rem;
        border-radius: 25px;
        font-size: .9rem;
        font-weight: 600;
        transition: all .5s;
    }

    .btn-secondary-sm:hover, .btn-secondary-md:hover {
        background: var(--btn-secondary-hover);
    }

    .btn-primary-md {
        background: var(--primary-color);
        border: 1px solid var(--primary-color);
        color: var(--light-color);
        padding: .5rem 12rem;
        border-radius: 25px;
        font-weight: 600;
        transition: all .2s;
    }

    .btn-primary-sm {
        background: var(--primary-color);
        border: 1px solid var(--primary-color);
        color: var(--light-color);
        padding: .9rem 5rem;
        border-radius: 25px;
        font-size: 0.9rem;
        font-weight: bold;
        transition: all .2s;
    }

    .btn-secondary-md {
        background: var(--light-color);
        border: 1px solid var(--primary-color);
        color: var(--primary-color);
        padding: .5rem 12rem;
        border-radius: 25px;
        font-weight: 600;
        transition: all .2s;
    }

    .btn-primary-md:hover {
        background: var(--btn-primary-hover);
    }

    .btn-primary-sm:hover {
        background: var(--btn-primary-hover);
    }
    /*--------------------------------*/

    /* FLEXBOX */
    .d-flex {
        display: flex;
    }

    .justify-content-center {
        justify-content: center;
    }

    .align-items-center {
        align-items: center;
    }

    .f-direction-column {
        flex-direction: column;
    }
    /*----------------------------*/

    /*----------------------------*/
    /*App styles*/

    #app {
    }

    .app-content {
        display: flex;
    }

    /*-----------------------------*/
</style>
