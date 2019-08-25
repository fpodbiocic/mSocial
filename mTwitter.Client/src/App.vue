<template>
    <div id="app">
        <router-view />
    </div>
</template>

<script>
    export default {
        name: 'App'
    };
</script>

<style>
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    :root {
        --primary-color: #1da1f2;
        --light-color : #fff;
    }

    body {
        font-family: 'Source Sans Pro', sans-serif;
    }

    .text-light {
        color: var(--light-color);
    }

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

    .mx-1 { margin: 0 1rem; }
    .mx-2 { margin: 0 2rem; }
    .mx-3 { margin: 0 3rem; }
    .mx-4 { margin: 0 4rem; }
    .mx-5 { margin: 0 5rem; }
    .mx-6 { margin: 0 6rem; }
</style>
