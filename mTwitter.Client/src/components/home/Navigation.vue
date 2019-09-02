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
            <li class="nav-item">
                <button>Tweet</button>
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
    }

</style>
