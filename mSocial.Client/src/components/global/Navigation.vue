<template>
    <div id="navigation">
        <div class="menu-item">
            <router-link to="/feed" class="menu-item-link" active-class="active">
                <a-badge dot>
                    <a-icon type="home" style="font-size: 1.4rem;" />
                </a-badge>
                Home
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/mynetwork" class="menu-item-link" active-class="active">
                <a-badge dot>
                    <a-icon type="team" style="font-size: 1.4rem;" />
                </a-badge>
                My Network
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/jobs" class="menu-item-link" active-class="active">
                <a-badge dot>
                    <a-icon type="fund" style="font-size: 1.4rem;" />
                </a-badge>
                Jobs
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/messages" class="menu-item-link" active-class="active">
                <a-badge count="1">
                    <a-icon type="message" style="font-size: 1.4rem;" />
                </a-badge>
                Messaging
            </router-link>
        </div>
        <div class="menu-item">
            <router-link to="/notifications" class="menu-item-link" active-class="active">
                <a-badge count="6">
                    <a-icon type="notification" style="font-size: 1.4rem;" />
                </a-badge>
                Notifications
            </router-link>
        </div>
        <div class="menu-item-user">
            <NavigationDropdown />
        </div>
    </div>
</template>

<script>
    import NavigationDropdown from "./NavigationDropdown.vue";

    export default {
        name: "Navigation",
        components: {
            NavigationDropdown: NavigationDropdown
        },
        data() {
            return {
            }
        }
    }
</script>

<style scoped>
    #navigation {
        margin-left: 7rem;
        display: flex;
    }

    #menu {
    }

    .menu-item, .menu-item-user {
        transition: all 0.2s;
        padding: 0.8rem 0;
    }

    .menu-item-user {
        color: #c7d1d8;
        cursor: pointer;
    }

    .menu-item-user a {
        color: #c7d1d8;
        text-decoration: none;
    }

    .menu-item-link {
        color: #c7d1d8;
        padding: 0.7rem 0.8rem;
        text-decoration: none;
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