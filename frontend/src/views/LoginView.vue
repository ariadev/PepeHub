<script setup>
	import Header from "../components/Header.vue";
</script>

<template>
	<div class="md:mx-auto mx-2 md:w-5/12 flex app h-screen">
		<div class="flex-grow flex flex-col items-center justify-center">
			<div class="p-3 rounded-lg shadow-md border bg-white lg:w-6/12">
				<img src="@/assets/login-image.jpg" class="mb-5 rounded-lg" alt="" />

				<h3 class="font-medium pb-2 mb-2 border-b">Login</h3>
				<div class="flex flex-col space-y-2">
					<div class="flex flex-col">
						<label for="username" class="tex-sm">Username</label>
						<input
							required
							class="p-3 border rounded text-sm"
							type="username"
							name="username"
							id="username"
							placeholder="Enter your username..."
						/>
					</div>
					<div class="flex flex-col">
						<label for="password" class="tex-sm">Password</label>
						<input
							required
							class="p-3 border rounded text-sm"
							type="password"
							name="password"
							id="password"
							placeholder="Enter your password..."
						/>
					</div>
					<button class="p-3 bg-black text-white font-medium rounded-lg text-sm">Submit</button>
				</div>
			</div>
		</div>
	</div>
</template>

<style scoped>
	.app {
		flex-flow: column;
	}
</style>
