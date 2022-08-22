<script setup>
	import Header from "../components/Header.vue";
	import AccountProfileSidebar from "../components/AccountProfileSidebar.vue";
	import AccountTabs from "../components/AccountTabs.vue";
	import AccountYourPepes from "../components/AccountYourPepes.vue";
</script>

<template>
	<div class="space-y-3 m-3 lg:mx-auto lg:w-6/12 flex flex-col">
		<Header />

		<div class="flex w-full lg:space-x-3">
			<main class="space-y-3 lg:w-4/6">
				<AccountTabs />

				<!--
                    Check the state management and see which tab is active
                    and show the right component.
                 -->
				<AccountYourPepes />
			</main>

			<div class="lg:w-2/6 space-y-3 hidden lg:inline-block">
				<AccountProfileSiderbar />
			</div>
		</div>
	</div>
</template>
