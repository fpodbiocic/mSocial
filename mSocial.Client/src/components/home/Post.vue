<template>
    <div class="post">
        <a-card>
            <!-- Post owner -->
            <h4 slot="title">
                <router-link to="/" class="post-owner">
                    <a-popover placement="left">
                        <template slot="title">Microsoft</template>
                        <template slot="content">Microsoft info</template>
                        <a-avatar size="large" icon="user" /> Microsoft
                    </a-popover>
                </router-link>
            </h4>
            <!-- Post owner end -->

            <!-- Post menu -->
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
            <!-- Post menu end -->

            <!-- Post body content -->
            <p>card content</p>
            <p>card content</p>
            <p>card content</p>
            <!-- Post body content end -->

            <!-- Post actions -->
            <template class="ant-card-actions" slot="actions">
                <!-- Like -->
                <a-icon type="like" />
                <!-- Comment -->
                <a-icon type="message" />
                <!-- Share menu -->
                <a-dropdown :trigger="['click']">
                    <a class="ant-dropdown-link" href="#">
                        <a-icon type="share-alt" />
                    </a>
                    <a-menu slot="overlay">
                        <a-menu-item key="0">
                            <router-link to="/">
                                <a-icon type="snippets" /> Share in a post
                            </router-link>
                        </a-menu-item>
                        <a-menu-item key="1">
                            <router-link to="/">
                                <a-icon type="message" /> Send as a private message
                            </router-link>
                        </a-menu-item>
                    </a-menu>
                </a-dropdown>
                <!-- End share menu -->
            </template>
            <!-- Post actions end -->
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

    .post-owner {
        color: #262626
    }
</style>