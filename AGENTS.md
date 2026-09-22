# Agent instructions

## Save system

- Before creating or modifying a tool, read and apply the
  [`.agents/skills/save-system/SKILL.md`](.agents/skills/save-system/SKILL.md)
  skill.
- Every implemented tool must also integrate saving and restoring its state
  through the project's save system. A tool is not considered complete unless
  its persistent state survives a save/load cycle.
- Include save round-trip tests in the same change and, whenever the persisted
  format changes, tests for compatibility with previous saves.
