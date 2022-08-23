<script setup>
	import AddNewPepe from "../components/AddNewPepe.vue";
	import Timeline from "../components/Timeline.vue";
	import MostPopularPepesSidebar from "../components/MostPopularPepesSidebar.vue";
	import MostPopularUsersSidebar from "../components/MostPopularUsersSidebar.vue";
	import SearchSidebar from "../components/SearchSidebar.vue";
	import Header from "../components/Header.vue";
</script>

<template>
	<div class="main">
		<Header />

		<div class="container">
			<main class="container-body">
				<!-- Create new pepe -->
				<AddNewPepe />

				<Timeline />
			</main>

			<div class="container-sidebar">
				<SearchSidebar />
				<MostPopularPepesSidebar />
				<MostPopularUsersSidebar />
			</div>
		</div>
	</div>
</template>

<style scoped>
	.main {
		@apply space-y-3 m-3 lg:mx-auto lg:w-6/12 flex flex-col;
	}

	.container {
		@apply flex w-full lg:space-x-3;
	}

	.container-body {
		@apply space-y-3 lg:w-4/6;
	}

	.container-siderbar {
		@apply lg:w-2/6 space-y-3 hidden lg:inline-block;
	}
</style>
