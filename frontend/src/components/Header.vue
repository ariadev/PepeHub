<script setup></script>

<template>
	<header class="flex flex-row justify-between items-center shadow-md px-2 py-1 rounded-lg">
		<RouterLink class="p-3 text-lg" to="/">
			<i class="fi fi-rr-home"></i>
		</RouterLink>
		<img alt="PepeHub Icon" class="logo" src="@/assets/logo/svg/pepe.svg" width="70" />

		<RouterLink class="p-3 text-lg" to="/about">
			<i class="fi fi-rr-user"></i>
		</RouterLink>
	</header>
</template>
