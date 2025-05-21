
# PayrollMigrator Claude Session Guide

This package contains a structured set of prompts and instructions for building the `Integrity.AI.PayrollMigrator` solution using Claude or another AI development assistant.

---

## Overview

This project supports payroll data migration from Microsoft GP to Business Central PayrollNow. It includes AI-assisted validation and natural language query capabilities using LangChain and Azure OpenAI/Claude.

---

## Contents

- `00-System-Prompt.md`: Setup for Claude to understand architecture, goals, and design constraints.
- `01-Prompt-*.md`: Initial project and model setup.
- `02-Services-Prompt-*.md`: Schema validation, LangChain, and BC service logic.
- `03-Storage-Prompt-*.md`: Blob and audit log storage clients.
- `04-LangCore-Prompt-*.md`: Web API backend for LangChain agent.
- `05-UI-Prompt-*.md`: WPF-based UI with MVVM pattern.
- `06-Tests-Prompt-*.md`: Unit testing for all modules.

---

## Usage Instructions

1. **Start Claude Session**:
   - Load `00-System-Prompt.md` into Claude first to establish system context.

2. **Proceed Step-by-Step**:
   - Feed Claude one prompt file at a time (e.g., `01-Prompt-1.md`, then `01-Prompt-2.md`).
   - Apply generated code to your local environment or repo.

3. **Track Progress**:
   - Use folder numbers as session checkpoints. Resume from where you last stopped.

4. **Testing**:
   - After code generation, run all tests described in `06-Tests-Prompt-*`.

---

## Best Practices

- Confirm dependencies and namespaces are correct in each session.
- Manually inspect or lint Claude's output to ensure code quality.
- Use version control to commit after each completed prompt.

---

Happy Building!
