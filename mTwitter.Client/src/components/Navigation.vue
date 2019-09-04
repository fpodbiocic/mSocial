<template>
    <div id="navigation">
        <ul class="nav">
            <li class="nav-item-logo">
                <router-link to="/home" class="nav-item-link-logo">
                    <i class="fab fa-twitter"></i> 
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/home" class="nav-item-link">
                    <i class="fas fa-home"></i> <span class="nav-item-link-text">Home</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/explore" class="nav-item-link">
                    <i class="fas fa-hashtag"></i> <span class="nav-item-link-text">Explore</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/notification" class="nav-item-link">
                    <i class="far fa-bell"></i> <span class="nav-item-link-text">Notifications</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/messages" class="nav-item-link">
                    <i class="far fa-envelope"></i> <span class="nav-item-link-text">Messages</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/bookmarks" class="nav-item-link">
                    <i class="far fa-bookmark"></i> <span class="nav-item-link-text">Bookmarks</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/lists" class="nav-item-link">
                    <i class="fas fa-stream"></i> <span class="nav-item-link-text">Lists</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/profile" class="nav-item-link">
                    <i class="far fa-user"></i> <span class="nav-item-link-text">Profile</span>
                </router-link>
            </li>
            <li class="nav-item">
                <router-link to="/more" class="nav-item-link">
                    <i class="fas fa-ellipsis-h"></i> <span class="nav-item-link-text">More</span>
                </router-link>
            </li>
            <li class="nav-item-tweet">
                <button class="btn btn-primary-sm">Tweet</button>
            </li>
        </ul>
    </div>
</template>

<script>
    export default {
        name: "Navigation"
    };
</script>

<style scoped>
    #navigation {
        width: 20%;
        /*border: 1px solid black;*/
    }

    .nav {
        /*border: 1px solid black;*/
    }

    .nav .nav-item, .nav-item-logo, .nav-item-tweet {
        float: left;
        clear: both;
        list-style-type: none;
        transition: all 0.1s;
    }

    .nav .nav-item {
        padding: 0.6rem;
        border-radius: 50px;
        margin-bottom: 1.1rem;
    }

    .nav .nav-item-logo {
        padding: 0.6rem;
        border-radius: 50%;
        margin-bottom: 1rem;
    }

    .nav .nav-item-logo .nav-item-link-logo {
        color: var(--primary-color);
    }

    .nav .nav-item:hover, .nav .nav-item-logo:hover {
        background: var(--btn-secondary-hover);
    }

    .nav .nav-item .nav-item-link {
        text-decoration: none;
        color: var(--dark-color);
    }

    .nav .nav-item .nav-item-link:hover {
        color: var(--primary-color);
    }

    .nav .nav-item .nav-item-link .nav-item-link-text {
        margin-left: 1.5rem;
        font-size: 1.2rem;
        font-weight: bold;
    }

    .nav .nav-item .nav-item-link i {
        font-size: 1.3rem;
    }

    .nav .nav-item-logo .nav-item-link-logo i {
        font-size: 1.7rem;
    }

    .nav .nav-item-tweet {
        display: block;
        text-align: left;
        width: 100%;
    }
</style>
