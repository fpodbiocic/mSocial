<template>
    <a-dropdown :trigger="['click']">
        <a class="ant-dropdown-link" href="#">
            <a-avatar icon="user" size="small" />
            Me <a-icon type="down-circle" />
        </a>
        <a-menu slot="overlay">
            <a-menu-item key="0">
                <router-link to="/profile" class="user-profile-dopdown-user-info">
                    <div>
                        <a-avatar icon="user" size="large" />
                    </div>
                    <div>
                        <h3>Marko Vidaković</h3>
                        <span>Software Engineer at mStart d.o.o.</span>
                    </div>
                </router-link>
            </a-menu-item>
            <a-menu-item key="1" style="text-align: center;">
                <router-link to="/profile"><a-icon type="idcard" /> View profile</router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="2">
                <router-link to="/settings-and-privacy">
                    <a-icon type="setting" /> Settings & Privacy
                </router-link>
            </a-menu-item>
            <a-menu-item key="3">
                <router-link to="/language">
                    <a-icon type="font-colors" /> Language
                </router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="5">
                <router-link to="/posts-and-activity">
                    <a-icon type="form" /> Posts & Activity
                </router-link>
            </a-menu-item>
            <a-menu-item key="6">
                <router-link to="/job-posting-account">
                    <a-icon type="unlock" /> Job posting account
                </router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="7">
                <router-link to="/signout">
                    <a-icon type="logout" /> Sign out
                </router-link>
            </a-menu-item>
        </a-menu>
    </a-dropdown>
</template>

<script>
    export default {
        name: "NavigationDropdown",
        data() {
            return {}
        }
    }
</script>

<style scoped>
    .user-profile-dopdown-user-info {
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .user-profile-dopdown-user-info > div {
        margin-right: 0.7rem;
    }
</style>