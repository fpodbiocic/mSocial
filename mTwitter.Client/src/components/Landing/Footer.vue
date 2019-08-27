<template>
    <footer>
        <span>&copy; 2019 Twitter</span>
    </footer>
</template>

<script>
    export default {
        name: "Footer"
    }
</script>

<style scoped>
    footer {
        background: var(--ligth-color);
        text-align: center;
        padding: .6rem 0;
    }

    footer span {
        font-size: 0.8rem;
        color: #c5b8cc;
    }
</style>