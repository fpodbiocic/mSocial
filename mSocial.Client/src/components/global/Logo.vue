<template>
    <div id="logo">
        <router-link to="/feed" id="logo">
            <a-icon type="linkedin" style="color: #c7d1d8; font-size: 2.3rem;" />
        </router-link>
    </div>
</template>

<script>
    export default {
        name: "Logo"
    }
</script>

<style scoped>
    #logo {
        margin-right: 1rem;
    }
</style>