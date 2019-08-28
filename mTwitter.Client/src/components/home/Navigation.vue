<template>
    <div id="navigation">
        <ul class="nav">
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link logo">
                    <i class="fab fa-twitter fa-2x"></i>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-home"></i> Home
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/notification" class="nav-item-link">
                    <i class="far fa-bell"></i> Notifications
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> Explore
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> Explore
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> Explore
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> Explore
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> Explore
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
        width: 20%;
        border: 1px solid black;
    }

    #navigation .nav {
    }

    #navigation .nav .nav-item {
        text-decoration: none;
        list-style-type: none;
        border: 1px solid black;
        float: left;
        clear: both;
        padding: .5rem;
        transition: all .5s;
    }

    #navigation .nav .nav-item:hover {
        background: var(--btn-secondary-hover);
        border-radius: 25px;
    }

    #navigation .nav .nav-item .nav-item-link {
        text-decoration: none;

    }

    .logo {
        color: var(--primary-color);
        display: inline-block;
    }
</style>