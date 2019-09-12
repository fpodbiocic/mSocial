<template>
    <a-card id="groups-card" v-bind:loading="loading" hoverable title="Your Groups">
        
    </a-card>
</template>

<script>
    export default {
        name: "HashtagsCard",
        data() {
            return {
                loading: false,
            }
        }
    }
</script>

<style scoped>
    #groups-card {
    }
</style>