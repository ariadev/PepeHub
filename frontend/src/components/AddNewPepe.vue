<script setup></script>

<template>
	<div class="border shadow rounded-lg flex flex-col">
		<div class="flex border-b">
			<input
				class="w-10/12 rounded-lg p-3 text-sm font-medium"
				type="text"
				placeholder="Add a title for pepe..."
			/>
			<button class="2/12 py-3 px-4 font-semibold rounded-tr-lg">Submit</button>
		</div>
		<textarea
			class="p-3 rounded-b-lg text-sm"
			name="content"
			placeholder="Let the pepe frog know what you have today..."
			cols="30"
			rows="2"
		></textarea>
	</div>
</template>
