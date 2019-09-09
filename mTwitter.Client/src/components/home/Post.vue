<template>
    <div >
        <router-link v-bind:to="{ name: 'tweet', params: { id: post.id } }" class="post">
            <div class="post-user-profile"><i class="fas fa-user fa-2x"></i></div>
            <div class="post-content">
                <div class="post-content-info">
                    <div>
                        <router-link to="" class="post-content-info-username">{{ post.createdBy }} <small>@puki_5</small></router-link>
                        <small>{{ post.createdOn | moment("from", "now", true) }}</small>
                    </div>
                    <div class="post-dropdown">
                        <small><i class="fas fa-angle-down"></i></small>
                    </div>
                </div>
                <div class="post-content-body">
                    <p>{{ post.body }}</p>
                </div>
                <div class="post-content-interaction">
                    <div class="post-content-interaction-item"><i class="far fa-comment comment"></i> <span class="comment-num">{{ post.comments }}</span></div>
                    <div class="post-content-interaction-item"><i class="fas fa-retweet retweet"></i> <span class="retweet-num">{{ post.retweets }}</span></div>
                    <div class="post-content-interaction-item"><i class="far fa-heart heart"></i> <span class="like-num">{{ post.likes }}</span></div>
                    <div class="post-content-interaction-item"><i class="fas fa-upload upload"></i></div>
                </div>
            </div>
        </router-link>
    </div>
</template>

<script>
    export default {
        props: {
            post: {
                type: Object,
                required: true
            }
        },
        name: "Post",
        data() {
            return {

            }
        }
    }
</script>

<style scoped>
    .post {
        border-bottom: 1px solid #e6ecf0;
        padding: 0.6rem 1rem;
        display: flex;
        transition: all 0.3s;
        text-decoration: none;
        color: var(--dark-color);
    }

    .post:hover {
        background: #f5f8fa;
        cursor: pointer;
    }

    .post .post-user-profile {
    }

    .post-content {
        width: 100%;
    }

    .post-content-info {
        display: flex;
        justify-content: space-between;
        padding-left: 0.5rem;
        /*border: 1px solid black;*/
    }

    .post-content-info .post-content-info-username {
        text-decoration: none;
        color: var(--dark-color);
        font-weight: bold;
        font-size: 15px;
    }

    .post-content-info .post-content-info-username:hover {
        text-decoration: underline;
    }

    .post-content-info small {
        color: #657786;
        padding: 0 0.5rem;
    }

    .post-content-body {
        padding-left: 0.5rem;
        padding-bottom: 0.5rem;
    }

    .post-content-interaction {
        display: flex;
    }

    .post-content-interaction-item {
        color: #657786;
        margin-right: 2.2rem;
    }

    .post-content-interaction-item i {
        padding: 0.5rem;
        border-radius: 50%;
        transition: all 0.1s;
    }

    /* COMMENT */
    .post-content-interaction-item i.comment:hover {
        color: var(--primary-color);
        background: var(--btn-secondary-hover);
    }

    .post-content-interaction-item i.comment:hover + .comment-num {
        color: var(--primary-color);
    }
    /*-------------------------------------------------------------*/

    /* RETWEET */
    .post-content-interaction-item i.retweet:hover {
        color: var(--retweet-color);
        background: var(--retweet-hover-color);
    }

    .post-content-interaction-item i.retweet:hover + .retweet-num {
        color: var(--retweet-color);
    }
    /*-----------------------------------------------------------*/

    /* LIKE */
    .post-content-interaction-item i.heart:hover {
        color: var(--like-color);
        background: var(--like-hover-color);
    }

    .post-content-interaction-item i.heart:hover + .like-num {
        color: var(--like-color);
    }
    /*-------------------------------------------------------*/

    /* UPLOAD */
    .post-content-interaction-item i.upload:hover {
        color: var(--primary-color);
        background: var(--btn-secondary-hover);
    }
    /*-------------------------------------------------------*/

    /* POST DROPDOWN */
    .post-dropdown small i {
        padding: 0.4rem 0.6rem;
        border-radius: 50%;
        transition: all 0.1s;
    }

    .post-dropdown small i:hover {
        color: var(--primary-color);
        background: var(--btn-secondary-hover);
    }
    /*-------------------------------------------------------*/

    .post-content-interaction-item span {
        padding-left: 0.3rem;
    }
</style>