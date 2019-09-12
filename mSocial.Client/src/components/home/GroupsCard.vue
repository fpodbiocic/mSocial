<template>
    <a-card id="groups-card" v-bind:loading="loading" title="Your Groups">
        <a href="#" slot="extra">
            <a-dropdown :trigger="['click']">
                <a class="ant-dropdown-link" href="#">
                    <a-icon type="ellipsis" />
                </a>
                <a-menu slot="overlay">
                    <a-menu-item key="0">
                        <router-link to="/groups/discover">
                            <a-icon type="search" /> Discover groups
                        </router-link>
                    </a-menu-item>
                    <a-menu-divider />
                    <a-menu-item key="3">
                        <router-link to="/groups/new">
                            <a-icon type="branches" /> Create a new group
                        </router-link>
                    </a-menu-item>
                </a-menu>
            </a-dropdown>
        </a>
        <a-tag><router-link to="/">Digital Marketing</router-link></a-tag>
        <a-tag>Harvard Business Review</a-tag>
        <a-tag>The Recruitment Network</a-tag>
        <a-tag>Vue.js</a-tag>
        <a-tag>React.js</a-tag>
        <template class="ant-card-actions" slot="actions">
            <a-popover title="Groups" placement="bottomRight">
                <template slot="content">
                    <p>Total number of groups</p>
                </template>
                <a-icon type="line-chart" /> <span>14 Total</span>
            </a-popover>
        </template>
    </a-card>
</template>

<script>
    export default {
        name: "GroupsCard",
        data() {
            return {
                loading: false,
            }
        }
    }
</script>

<style scoped>
    #groups-card {
    }

    .ant-dropdown-link {
        color: #898989;
    }

    .ant-dropdown-link:hover {
        color: #1890ff
    }
</style>