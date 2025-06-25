# SeniorEvaluation

Feature: Rate & Block Workers

Healthcare facilities using our shift management platform have requested functionality to:

Rate workers after each completed shift.

Block workers they no longer wish to work with.

This pull request introduces new endpoints to enable those actions.

Acceptance Criteria

✅ A facility can submit a rating (1–5 stars, optional comment) for a worker after a shift.

✅ A facility can block a worker from being assigned to future shifts.

✅ Blocked workers must not be assignable to future shifts at the blocking facility.
