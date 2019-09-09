<template>
    <div id="header">
        <div class="header-top">
            <h3>Home</h3>
        </div>
        <div class="header-bottom">
            <i class="far fa-user fa-2x"></i>
            
        </div>
    </div>
</template>

<script>
    export default {
        name: "Header"
    };
</script>

<style scoped>
    #header {
        /*border: 1px solid #e6ecf0;*/
        width: 600px;
    }

    #header .header-top {
        border-bottom: 1px solid #e6ecf0;
        padding: 0.6rem 1rem;
    }

        #header .header-bottom {
            padding: 0.6rem 1rem;
            border-bottom: 10px solid #e6ecf0;
        }
</style>