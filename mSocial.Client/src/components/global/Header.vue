<template>
    <div id="header">
        <a-row>
            <a-col :span="5"></a-col>
            <a-col :span="14" class="header-content">
                <router-link to="/feed" id="logo">
                    <a-icon type="linkedin" style="color: #c7d1d8; font-size: 2.3rem;" />
                </router-link>
                <AutoComplete />
            </a-col>
            <a-col :span="5"></a-col>
        </a-row>
    </div>
</template>

<script>
    import AutoComplete from "./AutoComplete.vue";

    export default {
        name: "Header",
        components: {
            AutoComplete: AutoComplete
        }
    }
</script>

<style scoped>
    #header {
        background: #283e4a;
        padding: 0.5rem 0;
    }

    h3 {
        color: #c7d1d8;
    }

    #logo {
        margin-right: 1rem;
    }

    .header-content {
        display: flex;
        align-items: center;
    }
</style>