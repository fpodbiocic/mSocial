<template>
    <a-card id="hashtags-card" v-bind:loading="loading" hoverable title="Followed Hashtags">
        <a-tabs defaultActiveKey="1" :tabPosition="tabPosition" :size="size" :tabBarGutter="tabBarGutter" :tabBarStyle="tabBarStyle">
            <a-tab-pane tab="Following" key="1">
                <router-link to="/">
                    # softwareengineering
                </router-link>
                <br />
                <router-link to="/">
                    # softwareengineering
                </router-link>
            </a-tab-pane>
            <a-tab-pane tab="Recent" key="2">
                <router-link to="/">
                    # softwareengineering
                </router-link>
                <br />
                <router-link to="/">
                    # softwareengineering
                </router-link>
            </a-tab-pane>
        </a-tabs>
        <template class="ant-card-actions" slot="actions">
            <router-link to="/feed/followed-hashtags">
                <a-icon type="flag" /> Discover more
            </router-link>
        </template>
    </a-card>
</template>

<script>
    export default {
        name: "HashtagsCard",
        data() {
            return {
                loading: false,
                tabPosition: 'top',
                size: 'small',
                tabBarGutter: 1,
                tabBarStyle: {
                }
            }
        }
    }
</script>

<style scoped>
    #hashtags-card {
        margin-bottom: 1rem;
    }

    
</style>