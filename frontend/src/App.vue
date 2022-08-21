<script setup>
	import { RouterLink, RouterView } from "vue-router";
	import Header from "./components/Header.vue";
</script>

<template>
	<div class="space-y-3 m-3 lg:mx-auto lg:w-6/12">
		<Header />
		<div class="">
			<RouterView />
		</div>
	</div>
</template>

<style scoped>
	a.router-link-exact-active {
		color: var(--color-text);
	}

	a.router-link-exact-active:hover {
		background-color: transparent;
	}

	a {
		display: inline-block;
		padding: 0 1rem;
		border-left: 1px solid var(--color-border);
	}
</style>
