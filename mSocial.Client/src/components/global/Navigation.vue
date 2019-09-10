<template>
    <div id="navigation">
        <div class="menu-item">
            <router-link to="/feed" class="menu-item-link active">
                <a-icon type="home" style="font-size: 1.2rem;" />
                Home
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/mynetwork" class="menu-item-link">
                <a-icon type="team" style="font-size: 1.2rem;" />
                My Network
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/jobs" class="menu-item-link">
                <a-icon type="fund" style="font-size: 1.2rem;" />
                Jobs
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/messages" class="menu-item-link">
                <a-icon type="message" style="font-size: 1.2rem;" />
                Messaging
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/notifications" class="menu-item-link">
                <a-icon type="notification" style="font-size: 1.2rem;" />
                Notifications
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/notifications" class="menu-item-link">
                <a-icon type="user" style="font-size: 1.2rem;" />
                Me
            </router-link>
        </div>
    </div>
</template>

<script>
    export default {
        name: "Navigation",
        data() {
            return {
                active: 'home'
            }
        }
    }
</script>

<style scoped>
    #navigation {
        margin-left: 9rem;
        display: flex;
    }

    #menu {
    }

    .menu-item {
        transition: all 0.2s;
    }

    .menu-item-link {
        display: flex;
        flex-direction: column;
        color: #c7d1d8;
        padding: 0.3rem 1.2rem;
    }

    .menu-item-link:hover {
        color: #fff;
    }

    .menu-item-icon {
        color: #c7d1d8;
    }

    .active {
        border-bottom: 2px solid #fff;
        color: #fff;
    }
</style>
<a-icon type="money-collect" />