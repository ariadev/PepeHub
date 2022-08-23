<script setup>
	import Header from "../components/Header.vue";
</script>

<template>
	<div class="main">
		<div class="container">
			<div class="container-body">
				<img src="@/assets/login-image.jpg" class="container-image" alt="" />

				<h3 class="container-header">Login</h3>
				<div class="form">
					<div class="form-item">
						<label for="username" class="text-sm">Username</label>
						<input
							required
							class="form-item-input"
							type="text"
							name="username"
							id="username"
							placeholder="Enter your username..."
						/>
					</div>
					<div class="form-item">
						<label for="password" class="text-sm">Password</label>
						<input
							required
							class="form-item-input"
							type="password"
							name="password"
							id="password"
							placeholder="Enter your password..."
						/>
					</div>
					<button class="form-item-button">Submit</button>
				</div>
			</div>
		</div>
	</div>
</template>

<style scoped>
	.main {
		@apply md:mx-auto mx-2 md:w-5/12 flex h-screen;
		flex-flow: column;
	}

	.container {
		@apply flex-grow flex flex-col items-center justify-center;
	}

	.container-body {
		@apply p-3 rounded-lg shadow-md border bg-white lg:w-6/12;
	}

	.container-image {
		@apply mb-5 rounded-lg;
	}

	.container-header {
		@apply font-medium pb-2 mb-2 border-b;
	}

	.form {
		@apply flex flex-col space-y-2;
	}

	.form-item {
		@apply flex flex-col space-y-2;
	}

	.form-input {
		@apply p-3 border rounded text-sm;
	}

	.form-item-button {
		@apply p-3 bg-black text-white font-medium rounded-lg text-sm;
	}
</style>
