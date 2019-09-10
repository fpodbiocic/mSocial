<template>
    <div id="header">
        <a-row>
            <a-col :span="5"></a-col>
            <a-col :span="14" class="header-content">
                <Logo />
                <AutoComplete />
                <Navigation />
            </a-col>
            <a-col :span="5"></a-col>
        </a-row>
    </div>
</template>

<script>
    import Logo from "./Logo.vue";
    import AutoComplete from "./AutoComplete.vue";
    import Navigation from "./Navigation.vue";

    export default {
        name: "Header",
        components: {
            Logo: Logo,
            AutoComplete: AutoComplete,
            Navigation: Navigation
        }
    }
</script>

<style scoped>
    #header {
        background: #283e4a;
        /*padding: 0.5rem 0;*/
    }

    .header-content {
        display: flex;
        align-items: center;
    }
</style>