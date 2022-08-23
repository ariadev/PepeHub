<script setup>
	import Header from "../components/Header.vue";
	import AccountTabs from "../components/AccountTabs.vue";
	import AccountYourPepes from "../components/AccountYourPepes.vue";
	import AccountProfileSidebar from "../components/AccountProfileSidebar.vue";
	import EditProfileModal from "../components/EditProfileModal.vue";
	import { ref } from "vue";

	const profileModalTrigger = ref(false);
</script>

<template>
	<div class="main">
		<Header />

		<div class="container">
			<main class="container-body">
				<AccountTabs />

				<!--
                    Check the state management and see which tab is active
                    and show the right component.
                 -->
				<AccountYourPepes />
			</main>

			<div class="container-sidebar">
				<AccountProfileSidebar />
			</div>
		</div>
	</div>

	<EditProfileModal v-if="profileModalTrigger" />
</template>

<style scoped>
	.main {
		@apply space-y-3 m-3 lg:mx-auto lg:w-6/12 flex flex-col;
	}

	.container {
		@apply flex w-full lg:space-x-3;
	}

	.container-body {
		@apply space-y-3 lg:w-5/6;
	}

	.container-siderbar {
		@apply lg:w-1/6 space-y-3 hidden lg:inline-block;
	}
</style>
