<template>
    <div id="create-post">
        <a-card title="">
            <a-button type="dashed" size="large" block @click="showCreatePostModal"><a-icon type="form" /> Create a new post</a-button>
            <a-modal v-model="visible"
                     title="Create a new post"
                     onOk="handleOk">
                <template slot="footer">
                    <a-button key="cancel" @click="handleCancel">Cancel</a-button>
                    <a-button key="post" type="primary" :loading="loading" @click="handleOk">
                        Post
                    </a-button>
                </template>
                <a-textarea placeholder="Post content" :rows="4" v-model="postBody" />
            </a-modal>
        </a-card>
    </div>
</template>

<script>

    export default {
        name: "CreatePost",
        data() {
            return {
                loading: false,
                visible: false,
                postBody: ""
            }
        },
        methods: {
            showCreatePostModal: function() {
                this.visible = true;
            },
            handleOk: function() {
                this.loading = true;
                setTimeout(() => {
                    this.visible = false;
                    this.loading = false;
                }, 3000);
            },
            handleCancel: function() {
                this.visible = false;
            },
        }
    }
</script>

<style scoped>
    #create-post {
        margin-bottom: 1rem;
    }
</style>