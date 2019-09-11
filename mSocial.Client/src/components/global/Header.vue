<template>
    <div id="header">
        <a-row>
            <a-col :span="5"></a-col>
            <a-col :span="14" class="header-content">
                <Logo />
                <Search />
                <Navigation />
            </a-col>
            <a-col :span="5"></a-col>
        </a-row>
    </div>
</template>

<script>
    import Logo from "./Logo.vue";
    import Search from "./Search.vue";
    import Navigation from "./Navigation.vue";

    export default {
        name: "Header",
        components: {
            Logo: Logo,
            Search: Search,
            Navigation: Navigation
        }
    }
</script>

<style scoped>
    #header {
        background: #283e4a;
    }

    .header-content {
        display: flex;
        align-items: center;
    }
</style>