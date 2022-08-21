<script setup>
	import { RouterLink } from "vue-router";
	import SinglePepeRate from "./SinglePepeRate.vue";
</script>

<template>
	<div class="p-3 border shadow bg-white rounded-lg flex flex-row">
		<div class="flex lg:w-1/12 w-1/6 flex-col justify-between">
			<img src="@/assets/avatar-placeholder.png" class="rounded-full" alt="pepe user avatar" />

			<SinglePepeRate />
		</div>
		<div class="flex flex-col lg:w-11/12 w-5/6 ml-3">
			<div class="border-b pb-1 mb-1">
				<RouterLink to="/pepe" class="flex underline text-blue-900 flex-col w-full">
					This is pepe title that you entered
				</RouterLink>
				<div class="flex text-sm space-x-2">
					<RouterLink to="/user/123/">@ariaseyedahmadi</RouterLink>
					<span>12/21/2021</span>
				</div>
			</div>
			<div>
				<p class="text-sm mb-2">
					Lorem ipsum dolor, sit amet consectetur adipisicing elit. Repellat, labore ullam? Molestias error
					dolorem incidunt ullam
				</p>
			</div>
			<div class="p-1 text-center mt-auto rounded-md bg-green-100 text-green-700 font-medium">
				<button class="text-sm">
					<span>Read More</span>
				</button>
			</div>
		</div>
	</div>
</template>

<style scoped></style>
