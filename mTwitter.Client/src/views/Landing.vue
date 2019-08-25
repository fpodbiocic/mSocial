<template>
    <div id="landing">
        <div class="landing-left">
            <div class="landing-left-box-top">
                <h2 class="text-light">You’re one step away from the shiny new Twitter.com</h2>
                <p class="text-light">We’ve added tons of cool features, including …</p>
                <button v-on:click="fetchPosts">Fetch post</button>
            </div>
            <div class="landing-left-box-bottom">
                <div></div>
                <div></div>
                <div></div>
            </div>
        </div>
        <div class="landing-right">

        </div>
    </div>
</template>

<script>
    export default {
        name: "Landing",
        data() {
            return {
                posts: []
            }
        },
        methods: {
            fetchPosts: function () {

                fetch('https://localhost:44341/api/Posts')
                    .then(response => {
                        return response.json();
                    })
                    .then(data => {
                        this.posts = data;
                        console.log(data)
                    })
                    .catch(error => console.log(error));

            }
        }
    };
</script>

<style scoped>
    #landing {
        display: flex;
        height: 100vh;
    }

    .landing-left {
        flex: 1;
        background: var(--primary-color);
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .landing-left-box-top {
        padding: 0 10rem;
        line-height: 1.5;
    }

    .landing-left-box-top h2 {
        font-size: 1.6rem;
    }

    .landing-right {
        flex: 1;
    }
</style>