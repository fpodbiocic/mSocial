<template>
    <div id="navigation">
        <ul class="nav">
            <li class="nav-link">
                <router-link to="/home" class="nav-link-item">
                    <div class="logo">
                        <i class="fab fa-twitter"></i>
                    </div>
                </router-link>
            </li>
            <li class="nav-link">
                <router-link to="/home" class="nav-link-item">
                    <div class="nav-link-item-icon">
                        <i class="fas fa-home"></i>
                    </div>
                    <div class="nav-link-item-text">
                        Home
                    </div>
                </router-link>
            </li>
            <li class="nav-link">
                <router-link to="/explore" class="nav-link-item">
                    <div class="nav-link-item-icon">
                        <i class="fas fa-hashtag"></i>
                    </div>
                    <div class="nav-link-item-text">
                        Explore
                    </div>
                </router-link>
            </li>
            <li class="nav-link">
                <router-link to="/notifications" class="nav-link-item">
                    <div class="nav-link-item-icon">
                        <i class="far fa-bell"></i>
                    </div>
                    <div class="nav-link-item-text">
                        Notifications
                    </div>
                </router-link>
            </li>
        </ul>
    </div>
</template>

<script>
    export default {
        name: "Navigation"
    }
</script>

<style scoped>
    #navigation {

    }

    #navigation .nav {

    }

    #navigation .nav .nav-link-logo {
        text-decoration: none;
        list-style-type: none;
        padding: 0 0 2.3rem 0;
        transition: all .5s;

    }

    #navigation .nav .nav-link {
        text-decoration: none;
        list-style-type: none;
        padding: 0 0 2rem 0;
        transition: all .5s;
    }

    #navigation .nav .nav-link .nav-link-item {
        display: flex;
        text-decoration: none;
        color: var(--dark-color);
    }

    #navigation .nav .nav-link .nav-link-item .nav-link-item-icon {
        font-size: 1.4rem;
    }

    #navigation .nav .nav-link .nav-link-item .nav-link-item-text {
        padding-left: 1.7rem;
        font-size: 1.2rem;
        font-weight: bold;
        align-self: flex-end;
    }

    .logo {
        font-size: 1.7rem;
        color: var(--primary-color)
    }
</style>