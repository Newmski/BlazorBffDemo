# BFF Demo

- MVC - https://localhost:7201
- Web - https://localhost:7124
- Blazor - https://localhost:7163

## Login

Single sign-on results when logging into each site:

|                      | Blazor | MVC    | Web    |
| -------------------- | ------ | ------ | ------ |
| Logging in to MVC    | N      | Y      | Y      |
| Logging in to Web    | N      | Y      | Y      |
| Logging in to Blazor | Y      | Y      | Y      |


## Logout

Single sign-on results when logging out of each site:

|                       | Blazor | MVC    | Web    |
| --------------------- | ------ | ------ | ------ |
| Logging out of MVC    | N      | Y      | Y      |
| Logging out of Web    | N      | Y      | Y      |
| Logging out of Blazor | Y      | Y      | N      |

## Summary

When logging in via MVC or Web, the Blazor site does not appear to be signed in.

When logging in via Blazor, single sign-on works across all 3 sites.

When logging out via MVC or Web, the MVC and Web sites are logged out. The Blazor site is not.

When logging out via Blazor, the MVC site is logged out. The Web site is not.
