<script setup>
	import Header from "../components/Header.vue";
</script>

<template>
	<div class="main">
		<Header />

		<div class="container">
			<h3 class="container-title">About PepeHub</h3>
			<div>
				<!-- <img src="@/assets/about" alt="about image" /> -->
				<p>
					Lorem ipsum dolor sit, amet consectetur adipisicing elit. Alias facere ab recusandae molestias, iste
					voluptatem eveniet maxime vero aspernatur quasi consectetur repudiandae expedita quam. Quis, sunt
					laudantium. Impedit, libero quis?
				</p>
			</div>
		</div>
	</div>
</template>

<style scoped>
	.main {
		@apply space-y-3 m-3 lg:mx-auto lg:w-6/12 flex flex-col;
	}

	.container {
		@apply flex flex-col space-y-3 w-full lg:space-x-3;
	}

	.container-title {
		@apply text-xl py-5 border-b w-full;
	}
</style>
