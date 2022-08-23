<script setup></script>

<template>
	<div class="modal">
		<div class="modal-frame">
			<h3 class="modal-frame-title">Edit Profile</h3>

			<div class="modal-frame-control">
				<div class="modal-frame-control-item">
					<label for="username" class="modal-frame-label">Edit Username</label>
					<input type="text" value="ariaseyedahmadi" class="modal-frame-input" />
				</div>
				<div class="modal-frame-control-item">
					<label for="bio" class="modal-frame-label">Edit Bio</label>
					<textarea id="bio" rows="4" placeholder="edit bio content" class="modal-frame-input"></textarea>
				</div>

				<div class="modal-frame-control-action">
					<button class="modal-frame-control-action-button">Apply Changes</button>
				</div>
			</div>
		</div>
	</div>
</template>

<style scoped>
	.modal {
		@apply fixed w-full h-full left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 flex flex-col justify-center items-center px-3 md:px-0;
		background-color: rgba(0, 0, 0, 0.075);
	}

	.modal-frame {
		@apply p-3 rounded-lg w-full md:w-3/12 shadow-2xl border bg-white flex flex-col;
	}

	.modal-frame-title {
		@apply font-semibold pb-3 border-b;
	}

	.modal-frame-control {
		@apply pt-3 flex flex-col w-full space-y-2;
	}

	.modal-frame-control-item {
		@apply flex flex-col;
	}

	.modal-frame-label {
		@apply text-sm font-medium mb-1;
	}

	.modal-frame-input {
		@apply p-3 border rounded text-sm;
	}

	.modal-frame-control-action {
		@apply flex flex-col;
	}

	.modal-frame-control-action-button {
		@apply p-3 bg-black text-white font-medium rounded-lg text-sm;
	}
</style>
