<template>
    <div id="app">
        <Header />
        <a-row>
            <a-col :xs="1" :sm="1" :md="2" :lg="5"></a-col>
            <a-col :xs="22" :sm="22" :md="20" :lg="14" id="main-content">
                <router-view name="left-sidebar" />
                <router-view />
                <router-view name="right-sidebar" />
            </a-col>
            <a-col :xs="1" :sm="1" :md="2" :lg="5"></a-col>
        </a-row>
    </div>
</template>

<script>
    import Header from "./components/global/Header.vue";

    export default {
        name: 'app',
        components: {
            Header: Header
        }
    };
</script>

<style>
    #main-content {
        margin-top: 3rem;
        /*border: 1px solid black;*/
    }

    #app {
        background: #f5f5f5;
        height: 100%;
    }
</style>
