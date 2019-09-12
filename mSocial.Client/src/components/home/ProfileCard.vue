<template>
    <a-card id="profile-card" v-bind:loading="loading" hoverable>
        <div class="card-user-info">
            <a-avatar :size="64" icon="user" />
            <router-link to="/profile">
                <h3>Marko Vidaković</h3>
            </router-link>
            <small>Software Engineer at mStart d.o.o.</small>
        </div>
        <template class="ant-card-actions" slot="actions">
            <router-link to="/settings">
                <a-popover title="Settings" placement="bottomRight">
                    <template slot="content">
                        <p>Manage your account</p>
                    </template>
                    <a-icon type="setting" />
                </a-popover>
            </router-link>
            <router-link to="/mynetwork">
                <a-popover title="Connections" placement="bottom">
                    <template slot="content">
                        <p>Grow your network</p>
                    </template>
                    <a-icon type="link" /> <span>48</span>
                </a-popover>
            </router-link>
            <router-link to="/profile-viewers">
                <a-popover title="Profile" placement="bottomLeft">
                    <template slot="content">
                        <p>Click to see who viewed your profile</p>
                    </template>
                    <a-icon type="eye" /> <span>109</span>
                </a-popover>
            </router-link>
        </template>
    </a-card>
</template>

<script>
    export default {
        name: "ProfileCard",
        data() {
            return {
                loading: false
            }
        }
    }
</script>

<style scoped>
    #profile-card {
        margin-bottom: 1rem;
    }

    .card-user-info {
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }
</style>