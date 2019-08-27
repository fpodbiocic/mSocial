<template>
    <div id="landing">
        <div class="landing-content">
            <div class="landing-left">
                <div class="landing-left-box-top">
                    <h2 class="text-light">You’re one step away from the shiny new Twitter.com</h2>
                    <p class="text-light">We’ve added tons of cool features, including …</p>
                </div>
                <div class="landing-left-box-bottom">
                    <div class="box">
                        <i class="fas fa-hashtag fa-2x text-light"></i>
                        <div class="mx-2">
                            <h3 class="text-light">Explore</h3>
                            <span class="text-light">Get the latest Tweets, news, and videos in one place.</span>
                        </div>
                    </div>
                    <div class="box">
                        <i class="far fa-bookmark fa-2x text-light"></i>
                        <div class="mx-2">
                            <h3 class="text-light">Bookmarks</h3>
                            <span class="text-light">Save that interesting Tweet for later.</span>
                        </div>
                    </div>
                    <div class="box">
                        <i class="fas fa-paint-brush fa-2x text-light"></i>
                        <div class="mx-2">
                            <h3 class="text-light">Personalize</h3>
                            <span class="text-light">Choose from new themes and more dark mode options.</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="landing-right">
                <div class="landing-right-login">
                    <form id="landing-login" v-on:submit="onSubmit">
                        <input type="email" placeholder="Email" v-model="email">
                        <input type="password" placeholder="Password" v-model="password">
                        <button type="submit" id="btnLandingLogin" class="btn btn-secondary-sm mx-05">Log in</button>
                    </form>
                </div>
                <div class="landing-right-register-login">
                    <div class="text-center">
                        <i class="fab fa-twitter fa-3x text-primary my-1"></i>
                        <h2>See what's happening in the world right now</h2>
                    </div>
                    <div class="my-1 d-flex f-direction-column text-center">
                        <h4 class="my-1">Join Twitter today.</h4>
                        <router-link to="/signup" class="btn btn-primary-md">Sign up</router-link>
                        <router-link to="/login" class="btn btn-secondary-md my-1">Log in</router-link>
                    </div>
                </div>
            </div>
        </div>
        <Footer />
    </div>
        
</template>

<script>
    import jwt_decode from "jwt-decode";
    import Footer from "../components/landing/Footer.vue";

    export default {
        name: "Landing",
        components: {
            Footer: Footer
        },
        data() {
            return {
                email: "",
                password: ""
            }
        },
        methods: {
            onSubmit: function (e) {

                e.preventDefault();

                const data = {
                    email: this.email,
                    password: this.password
                }

            }
        }
    };
</script>

<style scoped>
    .landing-content {
        display: flex;
        height: calc(100vh - 2.3rem);
    }

    .landing-left {
        /*flex: 1;*/
        width: 50%;
        background: var(--primary-color);
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }

    .landing-left-box-top {
        padding: 0 17rem;
        line-height: 1.5;
    }

    .landing-left-box-top h2 {
        font-size: 1.5rem;
    }

    .landing-left-box-top p {
        font-size: 1.2rem;
        margin-top: 1rem;
        font-weight: 500;
    }

    .landing-left-box-bottom {
        margin-top: 1rem;
        display: flex;
        flex-direction: column;
    }

    .landing-left-box-bottom .box {
        display: flex;
        align-items: center;
        margin-top: 2rem;
    }

    .box span {
        font-size: .8rem;
    }

    .landing-right {
        /*flex: 1;*/
        display: flex;
        flex-direction: column;
        width: 50%;
        padding: 2rem 6rem;
    }

    .landing-right-login {
        display: flex;
        justify-content: flex-end;
    }

    .landing-right-register-login{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items:center;
        height: 100vh;
    }


    /* MEDIA QUERIES - LANDING */

    /* smartphones */
    @media(max-width: 500px){
        .landing-content {
            flex-direction: column;
        }

        .landing-left {
            width: 100%;
            background: var(--primary-color);
            order: 2;
            height: 50vh;
        }

        .landing-right {
            display: flex;
            flex-direction: column;
            order: 1;
            width: 100%;
            padding: 2rem 6rem;
            height: 50vh;
        }

        .landing-right-login {
            display: none;
        }

        .landing-left-box-top {
            padding: 0 5rem;
            line-height: 1;
        }

        .landing-left-box-top h2 {
            font-size: 1.2rem;
        }

        .landing-left-box-top p {
            font-size: .9rem;
        }

        .landing-left-box-bottom {
            margin-top: 1rem;
        }

        .landing-left-box-bottom .box {
            margin-top: 1.5rem;
            padding: 0 2rem;
        }

        .landing-left-box-bottom .box h3 {
            font-size: 1rem;
        }

        .landing-left-box-bottom .box i{
            font-size: 1.5rem;
        }

        .landing-right-register-login i {
            font-size: 1.5rem;
        }

        .btn-primary-md {
            padding: 0.5rem 3.8rem;
        }

        .btn-secondary-md {
            padding: 0.5rem 3.8rem;
        }
    }

    /* tablet */
    @media(min-width: 501px) and (max-width: 768px){
        .landing-content {
            flex-direction: column;
        }

        .landing-left {
            width: 100%;
            background: var(--primary-color);
            order: 2;
            height: 50vh;
        }

        .landing-right {
            display: flex;
            flex-direction: column;
            order: 1;
            width: 100%;
            padding: 2rem 6rem;
            height: 50vh;
        }

        .landing-right-login {
            display: none;
        }

        .landing-left-box-top {
            padding: 0 5rem;
            line-height: 1;
        }

            .landing-left-box-top h2 {
                font-size: 1.4rem;
            }

            .landing-left-box-top p {
                font-size: 1.2rem;
            }
    }

    /* normal */
    @media(min-width: 769px) and (max-width: 1200px){

    }

    /* wide */
    @media(min-width: 1201px){

    }

    /* landscape */
    @media(max-height: 500px){

    }
</style>