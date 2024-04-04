namespace Course.Contracts.course;


public record LoginResponse(
    string Name,
    string Email,
    string Password
);