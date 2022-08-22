<script setup>
	import { RouterLink, RouterView } from "vue-router";
</script>

<template>
	<RouterView />
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
