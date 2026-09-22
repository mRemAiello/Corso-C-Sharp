---
name: save-system
description: Integrate features and tools with the project's save system, including serialization, restoration, compatibility, and tests. Use this skill whenever creating or modifying a tool, adding persistent state, changing a saved model, or working on save/load flows.
---

# Save System

Treat persistence as part of the feature, not as a follow-up task. Maintain a
single source of truth and reuse the infrastructure already available in the
repository.

## Workflow

1. **Understand the existing flow.** Locate the save contract, persisted models,
   type registry, save and load entry points, and existing tests. Do not
   introduce a second format or a parallel write path.
2. **Classify the tool's state.** Separate configuration and derivable runtime
   state from state that must survive a restart. Persist only the latter, but
   include every field required to rebuild the tool without changing its
   behavior.
3. **Define a stable identity.** Use the identifier and registration mechanism
   adopted by the project. Do not base the persisted format on display names,
   in-memory references, or details that may change.
4. **Connect both directions.** Implement state writing and reading in the same
   change. Register the tool with any factories, converters, discriminators, or
   supported-type lists used by the save system.
5. **Handle evolution.** Preserve the current format whenever possible. Give new
   fields safe defaults; for incompatible changes, add a migration or increment
   the version according to the existing conventions. Never invalidate previous
   saves silently.
6. **Verify the full cycle.** Save non-default state, create a fresh system
   instance, load the save, and compare both state and behavior. Do not test only
   the serializer or DTO directly.

## Requirements for every tool

Consider the implementation incomplete until it includes:

- a persisted representation of the relevant state;
- integration with the actual save and load entry points;
- default restoration when optional data is missing;
- handling for unknown or invalid data that follows the project's policy and
  does not hide errors;
- a `tool -> save -> fresh instance -> load -> tool` round-trip test;
- compatibility tests whenever an existing format changes.

If the tool is intentionally stateless, still persist or register its identity
when the save system must restore its presence, type, or configuration. Document
in code or tests why there is no other state to persist.

## Checks before delivery

- Run the save-system-specific tests and the tests for the affected project.
- Inspect the diff to ensure no new persistent field is written without being
  read, or read without being written.
- Verify that a previous save remains loadable or that an explicit, tested
  migration exists.
- Explain in the final summary how the new tool is saved and restored.
