<template>
    <div id="app">
        <router-view name="navigation" />
        <router-view />
        <router-view name="sidebar" />
    </div>
</template>

<script>
    export default {
        name: 'app'
    };
</script>

<style>

</style>
