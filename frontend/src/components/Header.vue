<script setup></script>

<template>
	<header class="flex flex-row justify-between items-center shadow-md px-2 py-1 rounded-lg">
		<RouterLink class="p-3 text-lg" to="/">
			<i class="fi fi-rr-home lg:hidden"></i>
			<span class="font-medium hidden lg:ml-2 lg:text-sm lg:inline-block">Home</span>
		</RouterLink>
		<img alt="PepeHub Icon" class="logo" src="@/assets/logo/svg/pepe.svg" width="70" />

		<RouterLink class="p-3 text-lg" to="/about">
			<i class="fi fi-rr-user lg:hidden"></i>
			<span class="font-medium hidden lg:ml-2 lg:text-sm lg:inline-block">Account</span>
		</RouterLink>
	</header>
</template>
