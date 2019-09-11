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
            <a-menu-item style="text-align: center;">
                <router-link to="/profile">View profile</router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="1" style="background: #f3f6f8; cursor: default;">
                <h3>ACCOUNT</h3>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="2">
                <router-link to="/settings-and-privacy">
                    Settings & Privacy
                </router-link>
            </a-menu-item>
            <a-menu-item key="3">
                <router-link to="/language">
                    Language
                </router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="4" style="background: #f3f6f8; cursor: default;">
                <h3>MANAGE</h3>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="5">
                <router-link to="/posts-and-activity">
                    Posts & Activity
                </router-link>
            </a-menu-item>
            <a-menu-item key="6">
                <router-link to="/job-posting-account">
                    Job posting account
                </router-link>
            </a-menu-item>
            <a-menu-divider />
            <a-menu-item key="6">
                <router-link to="/signout">
                    Sign out
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