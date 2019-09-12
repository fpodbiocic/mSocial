<template>
    <div id="home-left-sidebar">
        <ProfileCard />
        <HashtagsCard />
        <GroupsCard />
    </div>
</template>

<script>
    import ProfileCard from "./ProfileCard.vue";
    import HashtagsCard from "./HashtagsCard.vue";
    import GroupsCard from "./GroupsCard.vue";

    export default {
        name: "HomeLeftSidebar",
        components: {
            ProfileCard: ProfileCard,
            HashtagsCard: HashtagsCard,
            GroupsCard: GroupsCard
        }
    }
</script>

<style scoped>
    #home-left-sidebar {
    }

    
</style>