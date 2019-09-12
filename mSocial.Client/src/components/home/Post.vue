<template>
    <div class="post">
        <a-card>
            <h4 slot="title"><a-avatar size="large" icon="user" /> Microsoft</h4>
            <a href="#" slot="extra">
                <a-dropdown :trigger="['click']">
                    <a class="ant-dropdown-link" href="#">
                        <a-icon type="ellipsis" />
                    </a>
                    <a-menu slot="overlay">
                        <a-menu-item key="0">
                            <router-link to="/groups/discover">
                                <a-icon type="link" /> Copy link to post
                            </router-link>
                        </a-menu-item>
                        <a-menu-item key="3">
                            <router-link to="/groups/new">
                                <a-icon type="stop" /> Unfollow
                            </router-link>
                        </a-menu-item>
                    </a-menu>
                </a-dropdown>
            </a>
            <p>card content</p>
            <p>card content</p>
            <p>card content</p>
            <template class="ant-card-actions" slot="actions">
                <a-icon type="like" v-on:click="likePost" />
                <a-icon type="message" v-on:click="showCommentSection" />
                <a-dropdown :trigger="['click']">
                    <a class="ant-dropdown-link" href="#">
                        <a-icon type="share-alt" />
                    </a>
                    <a-menu slot="overlay">
                        <a-menu-item key="0">
                            <router-link to="/groups/discover">
                                <a-icon type="link" /> Share in a post
                            </router-link>
                        </a-menu-item>
                        <a-menu-item key="3">
                            <router-link to="/groups/new">
                                <a-icon type="stop" /> Send as a private message
                            </router-link>
                        </a-menu-item>
                    </a-menu>
                </a-dropdown>
            </template>
        </a-card>
    </div>
</template>

<script>
    export default {
        name: "Post",
        data() {
            return {

            }
        },
        methods: {
            likePost: function (e) {
                console.log(e.target);
            },
            showCommentSection: function (e) {

            }
        }
    }
</script>

<style scoped>
    .post {
        margin-bottom: 0.5rem;
    }
    .ant-dropdown-link {
        color: #898989;
    }

    .ant-dropdown-link:hover {
        color: #1890ff
    }
</style>